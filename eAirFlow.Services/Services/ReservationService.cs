using eAirFlow.Model.Messages;
using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using eAirFlow.Services.RabbitMQ;
using eAirFlow.Services.ReservationStateMachine;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class ReservationService : BaseCRUDService<Reservation, ReservationSearchObject, Database.Reservation, ReservationInsertRequest, ReservationUpdateRequest>, IReservationService
    {
        public BaseReservationState BaseReservationState { get; set; }
        private readonly IRabbitMQService _rabbitMq;


        public ReservationService(Database._210019Context context, IMapper mapper, BaseReservationState baseReservationState, IRabbitMQService rabbitMq) : base(context, mapper)
        {
            BaseReservationState = baseReservationState;
            _rabbitMq = rabbitMq;
        }

        public override IQueryable<Database.Reservation> AddFilter(ReservationSearchObject search, IQueryable<Database.Reservation> query)
        {
            if (search == null)
                return query;

            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId);

            if (search.FlightId.HasValue)
                query = query.Where(x => x.FlightId == search.FlightId);

            if (search.PaymentId.HasValue)
                query = query.Where(x => x.PaymentId == search.PaymentId);

            return query;
        }

        public override IQueryable<Database.Reservation> AddInclude(IQueryable<Database.Reservation> query)
        {
            return query
                .Include(r => r.Flight)
                .Include(r => r.Flight.Airline)
                .Include(r => r.Payment)
                .Include(r => r.Airport)
                .Include(r => r.CheckIns)
                .Include(r => r.MealType)
                .Include(r => r.Seat);
        }



        public override Reservation Insert(ReservationInsertRequest request)
        {
            Database.Seat? seat = null;

            if (request.SeatId.HasValue)
            {
                seat = _context.Seats.FirstOrDefault(s => s.SeatId == request.SeatId.Value);

                if (seat == null)
                    throw new Exception("Selected seat does not exist!");

                if (request.AirplaneId == null && seat.AirplaneId.HasValue)
                    request.AirplaneId = seat.AirplaneId;

                if (request.SelectedSeat == null)
                    request.SelectedSeat = seat.SeatNumber;
            }

            if (request.AirplaneId == null && request.FlightId.HasValue)
            {
                var flightAirplaneId = _context.Flights
                    .Where(f => f.FlightId == request.FlightId.Value)
                    .Select(f => f.AirplaneId)
                    .FirstOrDefault();

                if (flightAirplaneId.HasValue)
                    request.AirplaneId = flightAirplaneId;
            }

            if (request.AirplaneId == null)
                throw new Exception("AirplaneId is missing or the flight does not have an airplane assigned!");

            seat ??= _context.Seats.FirstOrDefault(s =>
                s.SeatNumber == request.SelectedSeat &&
                s.AirplaneId == request.AirplaneId.Value
            );

            if (seat == null)
                throw new Exception("Selected seat does not exist for this airplane!");

            var entity = _mapper.Map<Database.Reservation>(request);

            entity.SeatId = seat.SeatId;
            entity.StateMachine = "initial";
            entity.ReservationDate = DateTime.Now;
            entity.DateOfBirth = request.DateOfBirth;
            entity.Address = request.Address;
            entity.City = request.City;
            entity.Country = request.Country;
            entity.PassportNumber = request.PassportNumber;
            entity.Citizenship = request.Citizenship;
            entity.BaggageInfo = request.BaggageInfo;

            if (request.MealTypeId != null)
                entity.MealTypeId = request.MealTypeId;

            entity.AirportId = request.AirportId;

            _context.Reservations.Add(entity);
            _context.SaveChanges();

            var user = _context.Users.Find(request.UserId);
            var flight = _context.Flights
                .Include(f => f.Airline)
                .FirstOrDefault(f => f.FlightId == request.FlightId);

            try
            {
                _rabbitMq.SendEmail(new Email
                {
                    EmailTo = user.Email!,
                    ReceiverName = user.Name ?? "User",
                    Subject = "Your eAirFlow reservation is confirmed",
                    Message = $@"
                <h2>Reservation Successful!</h2>
                <p>Dear {user.Name},</p>
                <p>Your reservation has been successfully created.</p>

                <h3>Flight Details:</h3>
                <ul>
                    <li><strong>From:</strong> {flight.DepartureLocation}</li>
                    <li><strong>To:</strong> {flight.ArrivalLocation}</li>
                    <li><strong>Airline:</strong> {flight.Airline?.Name}</li>
                    <li><strong>Departure time:</strong> {flight.DepartureTime}</li>
                    <li><strong>Seat:</strong> {seat.SeatNumber}</li>
                </ul>

                <p>Thank you for choosing eAirFlow!</p>
            "
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("EMAIL SEND ERROR: " + ex.Message);
            }

            return _mapper.Map<Model.Models.Reservation>(entity);
        }


        public override Reservation Update(int id, ReservationUpdateRequest request)
        {
            var entity = GetById(id);
            var state = BaseReservationState.CreateState(entity.StateMachine);
            return state.Update(id, request);
        }

        public Reservation Confirm(int id)
        {
            var entity = GetById(id);
            var state = BaseReservationState.CreateState(entity.StateMachine);
            return state.Confirm(id);
        }

        public Reservation Cancel(int id)
        {
            var entity = GetById(id);
            var state = BaseReservationState.CreateState(entity.StateMachine);
            return state.Cancel(id);
        }

        public Reservation Complete(int id)
        {
            var entity = GetById(id);
            var state = BaseReservationState.CreateState(entity.StateMachine);
            return state.Complete(id);
        }

        public void Delete(int id)
        {
            var entity = _context.Reservations
                .FirstOrDefault(r => r.ReservationId == id);

            if (entity == null)
                throw new Exception("Reservation not found.");

            var checkins = _context.CheckIns
                .Where(c => c.ReservationId == id)
                .ToList();

            _context.CheckIns.RemoveRange(checkins);

            _context.Reservations.Remove(entity);
            _context.SaveChanges();
        }



        public Reservation Pay(int id)
        {
            var entity = GetById(id);
            if (entity == null)
                throw new Exception("Reservation not found.");

            var state = BaseReservationState.CreateState(entity.StateMachine ?? "initial");

            var result = state.Pay(id);

            return result;
        }

        public Reservation MarkAsPaid(int reservationId, int paymentId)
        {
            var dbEntity = _context.Reservations.Find(reservationId);

            if (dbEntity == null)
                throw new Exception("Reservation not found.");

            dbEntity.PaymentId = paymentId;

            Console.WriteLine("⬅ MarkAsPaid called");
            Console.WriteLine($"PaymentId = {paymentId}");
            Console.WriteLine($"Reservation ID = {reservationId}");
            Console.WriteLine($"Old PaymentId = {dbEntity.PaymentId}");
            _context.SaveChanges();
            var state = BaseReservationState.CreateState(dbEntity.StateMachine ?? "initial");

            var updated = state.Pay(reservationId);

            return updated;
        }

        public List<Reservation> GetByUser(int userId)
        {
            var query = AddInclude(_context.Reservations)
                .Where(r => r.UserId == userId)
                .ToList();

            var dtoList = new List<Reservation>();

            foreach (var ef in query)
            {
                var dto = _mapper.Map<Reservation>(ef);

                dto.Seat = ef.Seat != null ? _mapper.Map<Seat>(ef.Seat) : null;
                dto.MealType = ef.MealType != null ? _mapper.Map<MealType>(ef.MealType) : null;
                dto.Airport = ef.Airport != null ? _mapper.Map<Airport>(ef.Airport) : null;
                dto.Flight = ef.Flight != null ? _mapper.Map<Flight>(ef.Flight) : null;
                dto.Payment = ef.Payment != null ? _mapper.Map<Payment>(ef.Payment) : null;

                var lastCheckIn = ef.CheckIns
                .OrderByDescending(c => c.CheckinId)
                .FirstOrDefault();

                if (lastCheckIn != null)
                {
                    dto.CheckIn = _mapper.Map<eAirFlow.Model.Models.CheckIn>(lastCheckIn);
                }


                dtoList.Add(dto);
            }

            return dtoList;
        }




    }
}
