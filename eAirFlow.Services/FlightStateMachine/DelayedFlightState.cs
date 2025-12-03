using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.FlightStateMachine
{
    public class DelayedFlightState : BaseFlightState
    {
        public DelayedFlightState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }

        public override Model.Models.Flight Update(int id, FlightUpdateRequest request)
        {
            var entity = Context.Flights.Find(id);
            if (entity == null)
                throw new Exception("Flight not found");

            Mapper.Map(request, entity);
            Context.SaveChanges();

            return Mapper.Map<eAirFlow.Model.Models.Flight>(entity);
        }

        public override Model.Models.Flight Cancel(int id)
        {
            var entity = Context.Flights.Find(id);
            if (entity == null)
                throw new Exception("Flight not found");

            entity.StateMachine = "cancelled";
            Context.SaveChanges();

            return Mapper.Map<eAirFlow.Model.Models.Flight>(entity);
        }

        public override Model.Models.Flight Complete(int id)
        {
            var entity = Context.Flights.Find(id);
            if (entity == null)
                throw new Exception("Flight not found");

            entity.StateMachine = "completed";
            Context.SaveChanges();

            return Mapper.Map<eAirFlow.Model.Models.Flight>(entity);
        }

        public override Model.Models.Flight Delay(int id)
        {
            var entity = Context.Flights.Find(id);
            if (entity == null)
                throw new Exception("Flight not found");

            entity.StateMachine = "delayed";
            Context.SaveChanges();

            return Mapper.Map<eAirFlow.Model.Models.Flight>(entity);
        }

        public override Model.Models.Flight Board(int id)
        {
            var entity = Context.Flights.Find(id);
            if (entity == null)
                throw new Exception("Flight not found");

            entity.StateMachine = "boarding";
            Context.SaveChanges();

            return Mapper.Map<eAirFlow.Model.Models.Flight>(entity);
        }

    }
}
