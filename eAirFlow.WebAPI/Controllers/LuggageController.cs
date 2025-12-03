using eAirFlow.Model;
using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LuggageController : BaseCRUDController<Model.Models.Luggage, LuggageSearchObject, LuggageInsertRequest, LuggageUpdateRequest>
    {
        private readonly ILuggageService _service;
        private readonly IWebHostEnvironment _env;
        private readonly _210019Context _context;
        private readonly IMapper _mapper;

        public LuggageController(ILuggageService service, IWebHostEnvironment env, _210019Context context, IMapper mapper)
            : base(service)
        {
            _service = service;
            _env = env;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("employee/{employeeId}")]
        public IActionResult GetForEmployee(int employeeId)
        {
            var emp = _context.Employees
                .Include(e => e.Airport)
                .FirstOrDefault(e => e.EmployeeId == employeeId);

            if (emp == null || emp.AirportId == null)
                return Ok(new { count = 0, resultList = new List<Model.Models.Luggage>() });

            var result = _context.Luggages
                .Include(l => l.User)
                .Include(l => l.Airport)
                .Where(l => l.AirportId == emp.AirportId)
                .ToList();

            return Ok(new
            {
                count = result.Count,
                resultList = result.Select(x => _mapper.Map<Model.Models.Luggage>(x)).ToList()
            });
        }


        [HttpGet("my")]
        public IActionResult GetMyLuggage()
        {
            if (!int.TryParse(Request.Query["userId"], out int userId))
                return BadRequest("userId is required.");

            var result = _service.GetPaged(
                new LuggageSearchObject
                {
                    UserId = userId
                }
            );

            return Ok(result);
        }

        [HttpPost("report")]
        public async Task<IActionResult> ReportLost([FromForm] LuggageReportUploadRequest req)
        {
            if (req.Image == null)
                return BadRequest("Image is required.");

            var fileName = $"{Guid.NewGuid()}_{req.Image.FileName}";
            var path = Path.Combine(_env.WebRootPath, "uploads", fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await req.Image.CopyToAsync(stream);
            }

            var entity = _service.Insert(new LuggageInsertRequest
            {
                UserId = req.UserId,
                Description = req.Description,
                ImageUrl = $"uploads/{fileName}",
                AirportId = req.AirportId
            });

            return Ok(entity);
        }

        [HttpPut("markLost/{id}")]
        public IActionResult MarkLost(int id)
        {
            return Ok(_service.MarkLost(id));
        }

        [HttpPut("found/{id}")]
        public IActionResult Found(int id)
        {
            return Ok(_service.MarkFound(id));
        }

        [HttpPut("pickedup/{id}")]
        public IActionResult PickedUp(int id)
        {
            return Ok(_service.MarkPickedUp(id));
        }

    }
}
