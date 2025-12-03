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
    public class MissingLuggageState : BaseLuggageState
    {
        public MissingLuggageState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }

        public override Model.Models.Luggage Insert(LuggageInsertRequest request)
        {
            var entity = Mapper.Map<Database.Luggage>(request);

            entity.StateMachine = "missing";

            Context.Luggages.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.Models.Luggage>(entity);
        }

        public override Model.Models.Luggage MarkFound(int id)
        {
            var entity = Context.Luggages.Find(id);
            if (entity == null) throw new Exception("Luggage not found");

            entity.StateMachine = "found";
            Context.SaveChanges();

            return Mapper.Map<Model.Models.Luggage>(entity);
        }

        public override Model.Models.Luggage MarkLost(int id)
        {
            var entity = Context.Luggages.Find(id);
            if (entity == null) throw new Exception("Luggage not found");

            entity.StateMachine = "lost";
            Context.SaveChanges();

            return Mapper.Map<Model.Models.Luggage>(entity);
        }

    }
}
