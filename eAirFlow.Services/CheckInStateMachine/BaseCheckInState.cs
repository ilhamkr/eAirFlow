using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using eAirFlow.Services.FlightStateMachine;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.CheckInStateMachine
{
    public class BaseCheckInState
    {
        public _210019Context Context { get; set; }
        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }

        public BaseCheckInState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider)
        {
            Context = context;
            Mapper = mapper;
            ServiceProvider = serviceProvider;
        }


        public virtual BaseCheckInState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "pending":
                    return new PendingCheckInState(Context, Mapper, ServiceProvider);
                case "cancelled":
                    return new CancelledCheckInState(Context, Mapper, ServiceProvider);
                case "completed":
                    return new CompletedCheckInState(Context, Mapper, ServiceProvider);
                default:
                    throw new Exception("Invalid state");
            }
        }


        public virtual eAirFlow.Model.Models.CheckIn Insert(CheckInInsertRequest request)
        {
            throw new Exception("Insert not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.CheckIn Cancel(int id)
        {
            throw new Exception("Cancel not allowed in this state.");
        }

        public virtual eAirFlow.Model.Models.CheckIn Complete(int id)
        {
            throw new Exception("Complete not allowed in this state.");
        }

    }
}
