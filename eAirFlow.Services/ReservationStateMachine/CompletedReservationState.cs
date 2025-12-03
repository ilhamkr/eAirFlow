using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.ReservationStateMachine
{
    public class CompletedReservationState : BaseReservationState
    {
        public CompletedReservationState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }


    }
}
