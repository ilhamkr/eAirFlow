using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using eAirFlow.Services.Services;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : BaseCRUDController<Model.Models.Flight, FlightSearchObject, FlightInsertRequest, FlightUpdateRequest>
    {
        private readonly _210019Context _context;
        private readonly IMapper _mapper;

        public FlightController(IFlightService service, _210019Context context, IMapper mapper) : base(service)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("admin")]
        public IActionResult AdminInsert([FromBody] FlightInsertRequest request)
        {
            var result = (_service as IFlightService)!.AdminInsert(request);
            return Ok(result);
        }

        [HttpGet("{flightId}/occupied-seats")]
        public IActionResult GetOccupiedSeats(int flightId)
        {
            var seats = _context.Reservations
                .Where(r => r.FlightId == flightId)
                .Select(r => r.SeatId)
                .ToList();

            return Ok(seats);
        }

        [HttpGet("today/employee/{employeeId}")]
        public IActionResult GetTodayFlightsForEmployee(int employeeId)
        {
            var emp = _context.Employees
                .Include(e => e.Airport)
                .FirstOrDefault(e => e.EmployeeId == employeeId);

            if (emp == null || emp.AirportId == null)
                return Ok(new { count = 0, resultList = new List<Model.Models.Flight>() });

            var today = DateTime.Today;

            var flights = _context.Flights
                .Include(f => f.Airline)
                .ThenInclude(a => a.Airport)
                .Where(f =>
                    (f.DepartureTime != null && f.DepartureTime.Value.Date == today) ||
                    (f.ArrivalTime != null && f.ArrivalTime.Value.Date == today)
                )
                .Where(f =>
                    f.DepartureLocation == emp.Airport.City ||
                    f.ArrivalLocation == emp.Airport.City
                )
                .ToList();

            var result = _mapper.Map<List<Model.Models.Flight>>(flights);

            return Ok(new { count = result.Count, resultList = result });
        }





        [HttpGet("stats")]
        public IActionResult GetStats([FromQuery] string airportIds)
        {
            var ids = airportIds
                .Split(',')
                .Select(int.Parse)
                .ToList();

            var result = ((IFlightService)_service).GetStats(ids);

            return Ok(result);
        }

        [HttpGet("weekly-trend")]
        public IActionResult GetWeeklyTrend([FromQuery] string airportIds)
        {
            var ids = airportIds.Split(',').Select(int.Parse).ToList();
            var data = ((IFlightService)_service).GetWeeklyTrend(ids);
            return Ok(data);
        }

        [HttpGet("future-locations")]
        public IActionResult GetFutureLocations([FromQuery] int airlineId)
        {
            var result = ((IFlightService)_service).GetFutureLocations(airlineId);
            return Ok(result);
        }



        [HttpGet("today")]
        public IActionResult GetTodayFlights()
        {
            var result = _service.GetPaged(new FlightSearchObject
            {
                TodayOnly = true
            });

            return Ok(result);
        }

        [HttpPut("{id}/delayWithTime")]
        public IActionResult DelayWithTime(int id, [FromQuery] int minutes)
        {
            return Ok((_service as IFlightService).DelayWithTime(id, minutes));
        }

        [HttpGet("locations")]
        public IActionResult GetLocations([FromQuery] int airlineId)
        {
            var flights = _context.Flights
                .Where(f => f.AirlineId == airlineId)
                .ToList();

            var fromLocations = flights
                .Select(f => f.DepartureLocation)
                .Distinct()
                .ToList();

            var toLocations = flights
                .Select(f => f.ArrivalLocation)
                .Distinct()
                .ToList();

            return Ok(new
            {
                from = fromLocations,
                to = toLocations
            });
        }

        [HttpGet("dates")]
        public IActionResult GetDates([FromQuery] int airlineId, [FromQuery] string from, [FromQuery] string to)
        {
            var dates = _context.Flights
                .Where(f => f.AirlineId == airlineId &&
                            f.DepartureLocation == from &&
                            f.ArrivalLocation == to)
                .Select(f => f.DepartureTime!.Value.Date)
                .Distinct()
                .OrderBy(d => d)
                .ToList();

            return Ok(dates);
        }


        [HttpPut("{id}/schedule")]
        public Model.Models.Flight Schedule(int id)
        {
            return (_service as IFlightService).Schedule(id);
        }

        [HttpPut("{id}/delay")]
        public Model.Models.Flight Delay(int id)
        {
            return (_service as IFlightService).Delay(id);
        }

        [HttpPut("{id}/cancel")]
        public Model.Models.Flight Cancel(int id)
        {
            return (_service as IFlightService).Cancel(id);
        }

        [HttpPut("{id}/complete")]
        public Model.Models.Flight Complete(int id)
        {
            return (_service as IFlightService).Complete(id);
        }

        [HttpPut("{id}/boarding")]
        public Model.Models.Flight Boarding(int id)
        {
            return (_service as IFlightService).Boarding(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            (_service as IFlightService)!.Delete(id);
            return Ok();
        }


    }
}
