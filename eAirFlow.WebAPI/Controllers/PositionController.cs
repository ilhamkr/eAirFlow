using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionController
        : BaseCRUDController<Model.Models.Position, PositionSearchObject, PositionInsertRequest, PositionUpdateRequest>
    {
        private readonly _210019Context _context;

        public PositionController(IPositionService service, _210019Context context)
            : base(service)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePosition(int id)
        {
            var entity = _context.Positions.FirstOrDefault(x => x.PositionId == id);

            if (entity == null)
                return NotFound("Position not found");

            _context.Positions.Remove(entity);
            _context.SaveChanges();

            return Ok("Position deleted");
        }
    }
}
