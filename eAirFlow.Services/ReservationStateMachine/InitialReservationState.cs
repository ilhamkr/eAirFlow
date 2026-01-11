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
    public class InitialReservationState : BaseReservationState
    {
        public InitialReservationState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }

        public override Model.Models.Reservation Insert (ReservationInsertRequest request)
        {
            var entity = Mapper.Map<eAirFlow.Services.Database.Reservation>(request);
            entity.AirportId = request.AirportId;
            entity.StateMachine = "initial";
            entity.DateOfBirth = request.DateOfBirth;
            entity.Address = request.Address;
            entity.City = request.City;
            entity.Country = request.Country;
            entity.PassportNumber = request.PassportNumber;
            entity.Citizenship = request.Citizenship;
            entity.BaggageInfo = request.BaggageInfo;
            Context.Reservations.Add(entity);
            Context.SaveChanges();
            return Mapper.Map<Model.Models.Reservation>(entity);
        }

        public override Model.Models.Reservation Confirm(int id)
        {
            var entity = Context.Reservations.Find(id);

            if (entity == null) throw new Exception("Reservation not found.");
            entity.StateMachine = "confirmed";
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

            entity.StateMachine = "paid";

            entity.QrCodeBase64 = GenerateQrCode("RES-" + entity.ReservationId);

            Context.SaveChanges();

            return Mapper.Map<Model.Models.Reservation>(entity);
        }

    }
}
