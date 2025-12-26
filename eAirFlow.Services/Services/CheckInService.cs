using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.CheckInStateMachine;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class CheckInService : BaseCRUDService<CheckIn, CheckInSearchObject, Database.CheckIn, CheckInInsertRequest, CheckInUpdateRequest>, ICheckInService
    {

        public BaseCheckInState BaseCheckInState { get; set; }

        public CheckInService(Database._210019Context context, IMapper mapper, BaseCheckInState baseCheckInState) : base(context, mapper)
        {
            BaseCheckInState = baseCheckInState;
        }

        public override IQueryable<Database.CheckIn> AddFilter(
            CheckInSearchObject search,
            IQueryable<Database.CheckIn> query)
        {
            if (search.ReservationId.HasValue)
                query = query.Where(x => x.ReservationId == search.ReservationId.Value);

            if (search.SeatId.HasValue)
                query = query.Where(x => x.SeatId == search.SeatId.Value);

            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId.Value);


            query = query.Where(x => x.StateMachine == "completed");

            query = query
            .Include(x => x.User)
            .Include(x => x.Reservation)
                .ThenInclude(r => r.Flight)
                    .ThenInclude(f => f.Airline)
            .Include(x => x.Reservation)
                .ThenInclude(r => r.Flight)
            .Include(x => x.Reservation)
                .ThenInclude(r => r.Payment)
            .Include(x => x.Reservation)
                .ThenInclude(r => r.MealType)
            .Include(x => x.Reservation)
                .ThenInclude(r => r.Seat)
                    .ThenInclude(s => s.SeatClass)
            .Include(x => x.Reservation)
                .ThenInclude(r => r.Airport)
            .Include(x => x.Seat)
                .ThenInclude(s => s.SeatClass);



            return query;
        }



        public override CheckIn Insert(CheckInInsertRequest request)
        {
            var state = BaseCheckInState.CreateState("pending");
            return state.Insert(request);
        }


        public CheckIn Cancel(int id)
        {
            var entity = GetById(id);
            var state = BaseCheckInState.CreateState(entity.StateMachine);
            return state.Cancel(id);
        }

        public CheckIn Complete(int id)
        {
            var entity = GetById(id);
            var state = BaseCheckInState.CreateState(entity.StateMachine);
            return state.Complete(id);
        }
    }
}
