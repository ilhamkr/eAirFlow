using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Interfaces
{
    public interface ILuggageReportService : ICRUDService<LuggageReport, LuggageReportSearchObject, LuggageReportInsertRequest, LuggageReportUpdateRequest>
    {

    }
}
