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
    public class UserRoleService : BaseCRUDService<UserRole, UserRoleSearchObject, Database.UserRole, UserRoleInsertRequest, UserRoleUpdateRequest>, IUserRoleService
    {
        public UserRoleService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.UserRole> AddFilter(UserRoleSearchObject search, IQueryable<Database.UserRole> query)
        {
            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId.Value);

            if (search.RoleId.HasValue)
                query = query.Where(x => x.RoleId == search.RoleId.Value);

            return query;
        }

        public override void BeforeInsert(UserRoleInsertRequest request, Database.UserRole entity)
        {
            var exists = _context.UserRoles.Any(x => x.UserId == request.UserId && x.RoleId == request.RoleId);
            if (exists)
                throw new Exception("UserRole already exists");

            base.BeforeInsert(request, entity);
        }

        public override void BeforeUpdate(UserRoleUpdateRequest request, Database.UserRole entity)
        {
            base.BeforeUpdate(request, entity);
        }
    }
}
