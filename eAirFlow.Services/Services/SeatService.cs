using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class SeatService : BaseCRUDService<Seat, SeatSearchObject, Database.Seat, SeatInsertRequest, SeatUpdateRequest>, ISeatService
    {
        public SeatService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Seat> AddFilter(SeatSearchObject search, IQueryable<Database.Seat> query)
        {
            if (search.AirplaneId.HasValue)
                query = query.Where(x => x.AirplaneId == search.AirplaneId);

            if (search.SeatClassId.HasValue)
                query = query.Where(x => x.SeatClassId == search.SeatClassId);


            return query;
        }
    }
}
