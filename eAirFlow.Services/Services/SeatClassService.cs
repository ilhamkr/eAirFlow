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
    public class SeatClassService : BaseCRUDService<SeatClass, SeatClassSearchObject, Database.SeatClass, SeatClassInsertRequest, SeatClassUpdateRequest>, ISeatClassService
    {
        public SeatClassService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.SeatClass> AddFilter(SeatClassSearchObject search, IQueryable<Database.SeatClass> query)
        {
            if (!string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }

            return query;
        }
    }
}
