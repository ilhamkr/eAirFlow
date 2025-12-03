using eAirFlow.Model.Models;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using MapsterMapper;

namespace eAirFlow.Services.ReservationStateMachine
{
    public class ReservationStateMachine : IReservationStateMachine
    {
        private readonly BaseReservationState _baseState;
        private readonly _210019Context _context;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;

        public ReservationStateMachine(
            BaseReservationState baseState,
            _210019Context context,
            IMapper mapper,
            IServiceProvider serviceProvider)
        {
            _baseState = baseState;
            _context = context;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        public Model.Models.Reservation Pay(int id)
        {
            var entity = _context.Reservations.Find(id);

            if (entity == null)
                throw new Exception("Reservation not found.");

            var state = _baseState.CreateState(entity.StateMachine ?? "initial");

            return state.Pay(id);
        }
    }
}
