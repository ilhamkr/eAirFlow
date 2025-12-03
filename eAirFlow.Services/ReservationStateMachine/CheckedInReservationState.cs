using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.ReservationStateMachine
{
    public class CheckedInReservationState : BaseReservationState
    {
        public CheckedInReservationState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }

        public override Model.Models.Reservation Complete(int id)
        {
            var entity = Context.Reservations.Find(id);
            if (entity == null) throw new Exception("Reservation not found.");

            entity.StateMachine = "completed";
            Context.SaveChanges();
            return Mapper.Map<Model.Models.Reservation>(entity);
        }

    }
}
