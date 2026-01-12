using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TimeZoneController : ControllerBase
    {
        private readonly ITimeZoneService _service;

        public TimeZoneController(ITimeZoneService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.TimeZone> GetAll()
        {
            return _service.GetAll();
        }
    }
}
