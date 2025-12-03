using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.ReservationStateMachine
{
    public class ConfirmedReservationState : BaseReservationState
    {
        public ConfirmedReservationState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }

        public override Model.Models.Reservation Update(int id, ReservationUpdateRequest request)
        {
            var entity = Context.Reservations.Find(id);
            if (entity == null) throw new Exception("Reservation not found.");
            Mapper.Map(request, entity);
            Context.SaveChanges();
            return Mapper.Map<Model.Models.Reservation>(entity);
        }

        public override Model.Models.Reservation Complete(int id)
        {
            var entity = Context.Reservations.Find(id);
            if (entity == null) throw new Exception("Reservation not found.");
            entity.StateMachine = "completed";
            Context.SaveChanges();
            return Mapper.Map<Model.Models.Reservation>(entity);
        }

        public override Model.Models.Reservation Cancel(int id)
        {
            var entity = Context.Reservations.Find(id);
            if (entity == null) throw new Exception("Reservation not found.");
            entity.StateMachine = "cancelled";
            Context.SaveChanges();
            return Mapper.Map<Model.Models.Reservation>(entity);
        }

        public override Model.Models.Reservation Pay(int id)
        {
            var entity = Context.Reservations.Find(id);
            if (entity == null)
                throw new Exception("Reservation not found.");

            if (entity.StateMachine != "confirmed")
                throw new Exception("Payment allowed only in confirmed state!");

            entity.StateMachine = "paid";

            entity.QrCodeBase64 = GenerateQrCode(
                $"RES-{entity.ReservationId}-PAY-{entity.PaymentId}"
            );

            Context.SaveChanges();

            return Mapper.Map<Model.Models.Reservation>(entity);
        }


    }
}
