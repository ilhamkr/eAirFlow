using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using Mapster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Interfaces
{
    public interface ILuggageService : ICRUDService<Luggage, LuggageSearchObject, LuggageInsertRequest, LuggageUpdateRequest>
    {
        public Luggage MarkLost(int id);
        public Luggage MarkPickedUp(int id);
        public Luggage MarkFound(int id);
    }
}
