using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using eAirFlow.Services.LuggageStateMachine;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class LuggageService : BaseCRUDService<Luggage, LuggageSearchObject, Database.Luggage, LuggageInsertRequest, LuggageUpdateRequest>, ILuggageService
    {
        public BaseLuggageState BaseLuggageState { get; set; }

        public LuggageService(Database._210019Context context, IMapper mapper, BaseLuggageState baseLuggageState) : base(context, mapper)
        {
            BaseLuggageState = baseLuggageState;
        }

        public override IQueryable<Database.Luggage> AddFilter(LuggageSearchObject search, IQueryable<Database.Luggage> query)
        {
            if (search == null)
                return query;

            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId.Value);

            query = query.Include(x => x.Airport).Include(x=>x.User);


            if (!string.IsNullOrWhiteSpace(search.DescriptionContains))
                query = query.Where(x => x.Description != null && x.Description.Contains(search.DescriptionContains));

            return query;
        }

        public override Luggage Insert(LuggageInsertRequest request)
        {
            var state = BaseLuggageState.CreateState("missing");
            return state.Insert(request);
        }


        public Luggage MarkLost(int id)
        {
            var entity = GetById(id);
            var state = BaseLuggageState.CreateState(entity.StateMachine);
            return state.MarkLost(id);
        }

        public Luggage MarkPickedUp(int id)
        {
            var entity = GetById(id);
            var state = BaseLuggageState.CreateState(entity.StateMachine);
            return state.MarkPickedUp(id);
        }

        public Luggage MarkFound(int id)
        {
            var entity = GetById(id);
            var state = BaseLuggageState.CreateState(entity.StateMachine);
            return state.MarkFound(id);
        }

    }
}
