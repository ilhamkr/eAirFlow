using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
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

        public ReservationService(Database._210019Context context, IMapper mapper, BaseReservationState baseReservationState) : base(context, mapper)
        {
            BaseReservationState = baseReservationState;
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
            if (request.AirplaneId == null)
            {
                Console.WriteLine($"AIRPLANEID: {request.AirplaneId}");
                Console.WriteLine($"SELECTEDSEAT: {request.SelectedSeat}");

                throw new Exception("AirplaneId is missing!");
            }

            var seat = _context.Seats.FirstOrDefault(s =>
                s.SeatNumber == request.SelectedSeat &&
                s.AirplaneId == request.AirplaneId.Value
            );

            if (seat == null)
                throw new Exception("Selected seat does not exist for this airplane!");

            var entity = _mapper.Map<Database.Reservation>(request);

            entity.SeatId = seat.SeatId;
            entity.StateMachine = "initial";
            entity.ReservationDate = DateTime.Now;

            if (request.MealTypeId != null)
                entity.MealTypeId = request.MealTypeId;

            entity.AirportId = request.AirportId;

            _context.Reservations.Add(entity);
            _context.SaveChanges();

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
