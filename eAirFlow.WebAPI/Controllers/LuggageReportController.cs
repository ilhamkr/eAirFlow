using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LuggageReportController : BaseCRUDController<LuggageReport, LuggageReportSearchObject, LuggageReportInsertRequest, LuggageReportUpdateRequest>
    {
        public LuggageReportController(ILuggageReportService service) : base(service)
        {
        }
    }
}
