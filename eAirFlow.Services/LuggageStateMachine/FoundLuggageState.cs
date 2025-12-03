using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuggageModel = eAirFlow.Model.Models.Luggage;

namespace eAirFlow.Services.LuggageStateMachine
{
    public class FoundLuggageState : BaseLuggageState
    {
        public FoundLuggageState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider)
            : base(context, mapper, serviceProvider)
        {
        }

        public override LuggageModel MarkPickedUp(int id)
        {
            var entity = Context.Luggages.Find(id);
            if (entity == null) throw new Exception("Luggage not found");

            entity.StateMachine = "pickedup";
            Context.SaveChanges();

            return Mapper.Map<LuggageModel>(entity);
        }
    }
}
