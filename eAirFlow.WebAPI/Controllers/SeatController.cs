using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SeatController : BaseCRUDController<Model.Models.Seat, SeatSearchObject, SeatInsertRequest, SeatUpdateRequest>
    {
        private readonly _210019Context _context;
        public SeatController(ISeatService service, _210019Context context) : base(service)
        {
            _context = context;
        }

        [HttpGet("byAirplane/{airplaneId}")]
        public IActionResult GetByAirplane(int airplaneId)
        {
            var seats = _context.Seats
                .Where(s => s.AirplaneId == airplaneId)
                .Include(s => s.SeatClass)
                .ToList();

            return Ok(seats);
        }

    }
}
