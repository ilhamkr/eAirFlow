using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using eAirFlow.Services.RabbitMQ;
using EasyNetQ;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.FlightStateMachine
{
    public class BoardingFlightState : BaseFlightState
    {

        public BoardingFlightState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
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

    }
}
