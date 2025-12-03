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
    public class LostLuggageState : BaseLuggageState
    {
        public LostLuggageState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider)
            : base(context, mapper, serviceProvider)
        {
        }

        public override LuggageModel MarkFound(int id)
        {
            var entity = Context.Luggages.Find(id);
            if (entity == null) throw new Exception("Luggage not found");

            entity.StateMachine = "found";
            Context.SaveChanges();

            return Mapper.Map<LuggageModel>(entity);
        }
    }
}
