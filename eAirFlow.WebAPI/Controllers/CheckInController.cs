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
    public class CheckInController : BaseCRUDController<Model.Models.CheckIn, CheckInSearchObject, CheckInInsertRequest, CheckInUpdateRequest>
    {
        private readonly ICheckInService _checkInService;
        private readonly IMapper _mapper;
        private readonly _210019Context _context;
        public CheckInController(ICheckInService checkInService, _210019Context context, IMapper mapper) : base(checkInService)
        {
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
                return Ok(new { count = 0, resultList = new List<Model.Models.CheckIn>() });

            var result = _context.CheckIns
                .Include(c => c.User)
                .Include(c => c.Reservation)
                    .ThenInclude(r => r.Flight)
                .Include(c => c.Reservation)
                    .ThenInclude(r => r.Payment)
                .Include(c => c.Reservation)
                    .ThenInclude(r => r.MealType)
                .Include(c => c.Reservation)
                    .ThenInclude(r => r.Seat)
                .Where(c => c.Reservation.AirportId == emp.AirportId)
                .Where(c => c.StateMachine != "completed")
                .ToList();

            var mapped = result.Select(c => _mapper.Map<Model.Models.CheckIn>(c)).ToList();

            return Ok(new
            {
                count = mapped.Count,
                resultList = mapped
            });
        }


        [HttpPut("{id}/cancel")]
        public IActionResult CancelState(int id)
        {
            var result = ((ICheckInService)_service).Cancel(id);
            return Ok(result);
        }

        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            var result = ((ICheckInService)_service).Complete(id);
            return Ok(result);
        }

    }
}
