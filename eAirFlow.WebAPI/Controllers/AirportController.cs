using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using eAirFlow.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportController : BaseCRUDController<Airport, AirportSearchObject, AirportInsertRequest, AirportUpdateRequest>
    {
        private readonly IAirportService _airportService;
        public AirportController(IAirportService service)
            : base(service)
        {
            _airportService = service;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _airportService.Delete(id);
            return Ok();
        }
    }
}
