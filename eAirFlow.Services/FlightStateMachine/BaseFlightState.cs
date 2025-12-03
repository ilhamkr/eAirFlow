using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using eAirFlow.Model.Requests;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using eAirFlow.Model.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using eAirFlow.Services.FlightStateMachine;
using Flight = eAirFlow.Model.Models.Flight;

namespace eAirFlow.Services.FlightStateMachine
{
    public class BaseFlightState
    {
        public _210019Context Context { get; set; }
        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }

        public BaseFlightState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider)
        {
            Context = context;
            Mapper = mapper;
            ServiceProvider = serviceProvider;
        }

        public virtual BaseFlightState CreateState(string stateName)
        {
            stateName = stateName?.ToLower() ?? "initial";

            switch (stateName)
            {
                case "boarding":
                    return new BoardingFlightState(Context, Mapper, ServiceProvider);
                case "scheduled":
                    return new ScheduledFlightState(Context, Mapper, ServiceProvider);
                case "delayed":
                    return new DelayedFlightState(Context, Mapper, ServiceProvider);
                case "cancelled":
                    return new CancelledFlightState(Context, Mapper, ServiceProvider);
                case "completed":
                    return new CompletedFlightState(Context, Mapper, ServiceProvider);
                default:
                    throw new Exception("Invalid state");
            }
        }

        public virtual eAirFlow.Model.Models.Flight Insert(FlightInsertRequest request)
        {
            throw new Exception("Insert not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.Flight Update(int id, FlightUpdateRequest request)
        {
            throw new Exception("Update not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.Flight Schedule(int id)
        {
            throw new Exception("Schedule not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.Flight Delay(int id)
        {
            throw new Exception("Delay not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.Flight Cancel(int id)
        {
            throw new Exception("Cancel not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.Flight Complete(int id)
        {
            throw new Exception("Complete not allowed in this state.");
        }

        public virtual Flight Board(int id)
        {
            throw new Exception("Boarding not allowed in this state.");
        }

    }
}
