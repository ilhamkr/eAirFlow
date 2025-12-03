using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class RoleService : BaseCRUDService<Model.Models.Role, RoleSearchObject, Database.Role, RoleInsertRequest, RoleUpdateRequest>, IRoleService
    {
        public RoleService(_210019Context context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<Database.Role> AddFilter(RoleSearchObject search, IQueryable<Database.Role> query)
        {
            if (search == null)
                return query;

            if (!string.IsNullOrWhiteSpace(search.Name))
                query = query.Where(x => x.Name.Contains(search.Name));

            return base.AddFilter(search, query);
        }
    }
}
