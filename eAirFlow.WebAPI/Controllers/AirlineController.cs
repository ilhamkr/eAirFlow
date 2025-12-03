using eAirFlow.Model;
using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirlineController : BaseCRUDController<Airline, AirlineSearchObject, AirlineInsertRequest, AirlineUpdateRequest>
    {
        private readonly IAirlineService airlineService;

        public AirlineController(IAirlineService airlineService) : base(airlineService)
        {
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                (_service as IAirlineService)!.Delete(id);
                return Ok(new { message = "Airline deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


    }
}
