using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

using DbFlight = eAirFlow.Services.Database.Flight;
using ModelFlight = eAirFlow.Model.Models.Flight;
using System.Linq;
using eAirFlow.Model.Models;
using eAirFlow.Model;

namespace eAirFlow.Services.Services
{
    public class FlightService
        : BaseCRUDService<ModelFlight, FlightSearchObject, DbFlight, FlightInsertRequest, FlightUpdateRequest>,
          IFlightService
    {
        private readonly _210019Context _context;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _provider;

        public FlightService(_210019Context context, IMapper mapper, IServiceProvider provider)
            : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
            _provider = provider;
        }

        public override IQueryable<DbFlight> AddFilter(FlightSearchObject search, IQueryable<DbFlight> query)
        {
            query = query
                .Include(f => f.Airline)
                .ThenInclude(a => a.Airport);

            if (search == null)
                return query;

            if (search.AirlineId.HasValue)
                query = query.Where(f => f.AirlineId == search.AirlineId);

            if (!string.IsNullOrWhiteSpace(search.DepartureLocation))
                query = query.Where(f => f.DepartureLocation == search.DepartureLocation);

            if (!string.IsNullOrWhiteSpace(search.ArrivalLocation))
                query = query.Where(f => f.ArrivalLocation == search.ArrivalLocation);

            if (search.Date.HasValue)
            {
                var date = search.Date.Value.Date;
                query = query.Where(f => f.DepartureTime!.Value.Date == date);
            }

            if (search.TodayOnly == true)
            {
                var now = DateTime.Now;
                var todayStart = now.Date;
                var todayEnd = todayStart.AddDays(1).AddSeconds(-1);

                query = query.Where(f =>
                    (f.DepartureTime >= todayStart && f.DepartureTime >= now && f.DepartureTime <= todayEnd)
                    ||
                    (f.DepartureTime <= now && f.ArrivalTime >= now)
                );
            }

            return query;
        }

        public List<Model.Models.Flight> GetFlightsForEmployee(int employeeId)
        {
            var emp = _context.Employees
                .FirstOrDefault(e => e.EmployeeId == employeeId);

            if (emp == null || emp.AirportId == null)
                return new List<Model.Models.Flight>();

            var flights = _context.Flights
                .Where(f => f.DepartureLocation == emp.Airport.Name
                         || f.ArrivalLocation == emp.Airport.Name)
                .ToList();

            return _mapper.Map<List<Model.Models.Flight>>(flights);
        }


        public async Task<Dictionary<string, object>> GetStats(List<int> airportIds)
        {
            var completed = await _context.Flights
                .Where(f => airportIds.Contains(f.Airline.AirportId.GetValueOrDefault()))
                .Where(f => f.StateMachine == "completed")
                .CountAsync();

            var canceled = await _context.Flights
                .Where(f => airportIds.Contains(f.Airline.AirportId.GetValueOrDefault()))
                .Where(f => f.StateMachine == "cancelled")
                .CountAsync();

            var delayed = await _context.Flights
                .Where(f => airportIds.Contains(f.Airline.AirportId.GetValueOrDefault()))
                .Where(f => f.StateMachine == "delayed")
                .CountAsync();

            var totalRevenue = await _context.Reservations
                .Include(r => r.Flight)
                    .ThenInclude(f => f.Airline)
                .Where(r => r.StateMachine == "paid")
                .Where(r => r.Flight != null)
                .Where(r => r.Flight.Airline != null)
                .Where(r => airportIds.Contains(r.Flight.Airline.AirportId.GetValueOrDefault()))
                .SumAsync(r => (decimal?)r.Payment.Amount) ?? 0m;


            var topAirlines = await _context.Flights
                .Where(f => airportIds.Contains(f.Airline.AirportId.GetValueOrDefault()))
                .Where(f => f.StateMachine == "completed")
                .GroupBy(f => f.Airline.Name)
                .Select(g => new { airline = g.Key, count = g.Count() })
                .OrderByDescending(x => x.count)
                .ToListAsync();

            var topDestinations = await _context.Flights
                .Where(f => airportIds.Contains(f.Airline.AirportId.GetValueOrDefault()))
                .Where(f => f.StateMachine == "completed")
                .GroupBy(f => f.ArrivalLocation)
                .Select(g => new { destination = g.Key, count = g.Count() })
                .OrderByDescending(x => x.count)
                .ToListAsync();

            var recentFlights = await _context.Flights
                .Where(f => f.DepartureTime != null)
                .Where(f => f.DepartureTime >= DateTime.Today.AddDays(-7))
                .ToListAsync();

            var weeklyTrend = Enumerable.Range(0, 7)
                .Select(i => DateTime.Today.AddDays(-i))
                .Select(date => new WeeklyTrendDto
                {
                    Day = date.ToString("ddd"),
                    Completed = recentFlights.Count(f =>
                        f.StateMachine == "completed" &&
                        f.DepartureTime!.Value.Date == date),

                    Canceled = recentFlights.Count(f =>
                        f.StateMachine == "cancelled" &&
                        f.DepartureTime!.Value.Date == date),

                    Delayed = recentFlights.Count(f =>
                        f.StateMachine == "delayed" &&
                        f.DepartureTime!.Value.Date == date)
                })
                .OrderBy(x => x.Day)
                .ToList();

            return new Dictionary<string, object>
    {
        { "completed", completed },
        { "canceled", canceled },
        { "delayed", delayed },
        { "totalRevenue", totalRevenue },
        { "topAirlines", topAirlines },
        { "topDestinations", topDestinations },
        { "weeklyTrend", weeklyTrend }
    };
        }




        public async Task<List<WeeklyTrendDto>> GetWeeklyTrend(List<int> airportIds)
        {
            var recentFlights = await _context.Flights
                .Where(f => f.DepartureTime != null)
                .Where(f => f.DepartureTime >= DateTime.Today.AddDays(-7))
                .Include(f => f.Airline)
                .ToListAsync();

            var result = Enumerable.Range(0, 7)
                .Select(i => DateTime.Today.AddDays(-i))
                .Select(date => new WeeklyTrendDto
                {
                    Day = date.ToString("ddd"),
                    Completed = recentFlights.Count(f =>
                        f.StateMachine == "completed" &&
                        f.DepartureTime!.Value.Date == date),

                    Canceled = recentFlights.Count(f =>
                        f.StateMachine == "cancelled" &&
                        f.DepartureTime!.Value.Date == date),

                    Delayed = recentFlights.Count(f =>
                        f.StateMachine == "delayed" &&
                        f.DepartureTime!.Value.Date == date)
                })
                .OrderBy(x => x.Day)
                .ToList();

            return result;
        }




        public void Delete(int id)
        {
            var entity = _context.Flights.FirstOrDefault(x => x.FlightId == id);

            if (entity == null)
                throw new Exception("Flight not found.");

            _context.Flights.Remove(entity);
            _context.SaveChanges();
        }


        private BaseFlightState GetState(DbFlight entity)
        {
            var baseState = new BaseFlightState(_context, _mapper, _provider);
            return baseState.CreateState(entity.StateMachine);
        }

        public override IQueryable<DbFlight> AddInclude(IQueryable<DbFlight> query)
        {
            return query
                .Include(f => f.Airline)
                .ThenInclude(a => a.Airport);
        }


        private DbFlight GetDbEntity(int id)
        {
            var dbEntity = _context.Flights.FirstOrDefault(x => x.FlightId == id);
            if (dbEntity == null)
                throw new Exception("Flight not found");

            return dbEntity;
        }

        public override ModelFlight Insert(FlightInsertRequest request)
        {
            var baseState = new BaseFlightState(_context, _mapper, _provider);
            var state = baseState.CreateState("scheduled");
            return state.Insert(request);
        }

        public ModelFlight DelayWithTime(int id, int minutes)
        {
            var entity = _context.Flights.FirstOrDefault(x => x.FlightId == id);
            if (entity == null)
                throw new Exception("Flight not found");

            entity.DepartureTime = entity.DepartureTime?.AddMinutes(minutes);
            entity.ArrivalTime = entity.ArrivalTime?.AddMinutes(minutes);

            entity.StateMachine = "delayed";

            _context.SaveChanges();

            var reservations = _context.Reservations.Where(r => r.FlightId == id).ToList();

            foreach (var r in reservations)
            {
                _context.Notifications.Add(new Database.Notification
                {
                    UserId = r.UserId,
                    Message = $"Flight from {entity.DepartureLocation} to {entity.ArrivalLocation} has been delayed by {minutes} minutes.",
                    SentAt = DateTime.Now,
                    IsSeen = false
                });
            }

            _context.SaveChanges();

            return _mapper.Map<ModelFlight>(entity);
        }

        public ModelFlight AdminInsert(FlightInsertRequest request)
        {
            var airline = _context.Airlines
                .Include(a => a.Airplanes)
                .FirstOrDefault(a => a.AirlineId == request.AirlineId);

            if (airline == null)
                throw new Exception("Airline not found");

            var airplane = airline.Airplanes.FirstOrDefault();

            if (airplane == null)
                throw new Exception("Selected airline has no airplanes assigned");

            var db = new DbFlight
            {
                DepartureLocation = request.DepartureLocation,
                ArrivalLocation = request.ArrivalLocation,
                DepartureTime = request.DepartureTime,
                ArrivalTime = request.ArrivalTime,
                AirlineId = request.AirlineId,
                AirplaneId = airplane.AirplaneId,
                Price = request.Price,
                StateMachine = "scheduled"
            };

            _context.Flights.Add(db);
            _context.SaveChanges();

            return _mapper.Map<ModelFlight>(db);
        }

        public Dictionary<string, List<string>> GetFutureLocations(int airlineId)
        {
            var now = DateTime.Now;

            var flights = _context.Flights
                .Where(f => f.AirlineId == airlineId &&
                            f.DepartureTime > now)
                .ToList();


            var fromLocations = flights
                .Select(f => f.DepartureLocation)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            var toLocations = flights
                .Select(f => f.ArrivalLocation)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return new Dictionary<string, List<string>>
    {
        { "from", fromLocations },
        { "to", toLocations }
    };
        }



        public override ModelFlight Update(int id, FlightUpdateRequest request)
        {
            var dbEntity = GetDbEntity(id);
            var state = GetState(dbEntity);
            return state.Update(id, request);
        }

        public ModelFlight Schedule(int id)
        {
            var dbEntity = GetDbEntity(id);
            var state = GetState(dbEntity);
            return state.Schedule(id);
        }

        public ModelFlight Delay(int id)
        {
            var dbEntity = GetDbEntity(id);
            var state = GetState(dbEntity);
            return state.Delay(id);
        }

        public ModelFlight Cancel(int id)
        {
            var dbEntity = GetDbEntity(id);
            var state = GetState(dbEntity);
            return state.Cancel(id);
        }

        public ModelFlight Complete(int id)
        {
            var dbEntity = GetDbEntity(id);
            var state = GetState(dbEntity);
            return state.Complete(id);
        }

        public ModelFlight Boarding(int id)
        {
            var dbEntity = GetDbEntity(id);
            var state = GetState(dbEntity);
            return state.Board(id);
        }

    }
}
