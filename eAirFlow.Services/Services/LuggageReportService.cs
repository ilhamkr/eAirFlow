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
    public class LuggageReportService : BaseCRUDService<LuggageReport, LuggageReportSearchObject, Database.LuggageReport, LuggageReportInsertRequest, LuggageReportUpdateRequest>, ILuggageReportService
    {
        public LuggageReportService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.LuggageReport> AddFilter(LuggageReportSearchObject search, IQueryable<Database.LuggageReport> query)
        {
            if (search == null)
                return query;

            if (search.LuggageId.HasValue)
                query = query.Where(x => x.LuggageId == search.LuggageId.Value);

            if (search.EmployeeId.HasValue)
                query = query.Where(x => x.EmployeeId == search.EmployeeId.Value);

            if (!string.IsNullOrWhiteSpace(search.ReportType))
                query = query.Where(x => x.ReportType != null && x.ReportType.Contains(search.ReportType));

            return base.AddFilter(search, query);
        }
    }
}
