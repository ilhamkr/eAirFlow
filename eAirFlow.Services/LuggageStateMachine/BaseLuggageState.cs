using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.LuggageStateMachine
{
    public class BaseLuggageState
    {
        public _210019Context Context { get; set; }
        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }

        public BaseLuggageState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider)
        {
            Context = context;
            Mapper = mapper;
            ServiceProvider = serviceProvider;
        }

        public virtual BaseLuggageState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "missing":
                    return new MissingLuggageState(Context, Mapper, ServiceProvider);
                case "found":
                    return new FoundLuggageState(Context, Mapper, ServiceProvider);
                case "lost":
                    return new LostLuggageState(Context, Mapper, ServiceProvider);
                case "pickedup":
                    return new PickedUpLuggageState(Context, Mapper, ServiceProvider);
                default:
                    throw new Exception("Invalid state");
            }
        }

        public virtual Model.Models.Luggage Insert(LuggageInsertRequest request)
        {
            throw new Exception("Insert not allowed in this state.");
        }

        public virtual Model.Models.Luggage MarkFound(int id)
        {
            throw new Exception("MarkFound not allowed in this state.");
        }

        public virtual Model.Models.Luggage MarkLost(int id)
        {
            throw new Exception("MarkLost not allowed in this state.");
        }

        public virtual Model.Models.Luggage MarkPickedUp(int id)
        {
            throw new Exception("Deliver not allowed in this state.");
        }

    }
}
