using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class EmployeeService : BaseCRUDService<Employee, EmployeeSearchObject, Database.Employee, EmployeeInsertRequest, EmployeeUpdateRequest>, IEmployeeService
    {
        public EmployeeService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Employee> AddFilter(EmployeeSearchObject search, IQueryable<Database.Employee> query)
        {
            query = query
                .Include(x => x.Position)
                .Include(x => x.User);

            if (!string.IsNullOrWhiteSpace(search.NameGTE))
                query = query.Where(x => x.Name.Contains(search.NameGTE));

            if (!string.IsNullOrWhiteSpace(search.SurnameGTE))
                query = query.Where(x => x.Surname.Contains(search.SurnameGTE));

            if (!string.IsNullOrWhiteSpace(search.Email))
                query = query.Where(x => x.Email.Contains(search.Email));

            return base.AddFilter(search, query);
        }

    }
}
