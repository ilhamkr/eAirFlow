using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eAirFlow.Services.Database;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : BaseCRUDController<Model.Models.Employee, EmployeeSearchObject, EmployeeInsertRequest, EmployeeUpdateRequest>
    {
        private readonly _210019Context _context;
        public EmployeeController(IEmployeeService employeeService, _210019Context context) : base(employeeService)
        {
            _context = context;
        }

        [HttpPost("assign")]
        public IActionResult AssignEmployee([FromBody] AssignEmployeeRequest request)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserId == request.UserId);
            if (user == null) return NotFound("User not found");

            var existing = _context.Employees
                .Include(e => e.Position)
                .Include(e => e.Airport)
                .FirstOrDefault(e => e.UserId == request.UserId);

            if (existing != null)
                return Ok(existing);

            var airport = _context.Airports.FirstOrDefault(a => a.AirportId == request.AirportId);
            if (airport == null) return NotFound("Airport not found");

            var employee = new eAirFlow.Services.Database.Employee
            {
                UserId = request.UserId,
                PositionId = request.PositionId,
                AirportId = request.AirportId,
                HireDate = DateTime.Now,

                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            var populated = _context.Employees
                .Include(e => e.Position)
                .Include(e => e.Airport)
                .FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);

            return Ok(populated);
        }


        [HttpPut("change-position/{userId}")]
        public IActionResult ChangePosition(int userId, [FromBody] AssignEmployeeRequest request)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.UserId == userId);
            if (employee == null)
                return NotFound("Employee not found");

            employee.PositionId = request.PositionId;
            _context.SaveChanges();

            return Ok(employee);
        }

        [HttpPut("change-airport/{userId}")]
        public IActionResult ChangeAirport(int userId, [FromBody] ChangeAirportRequest request)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.UserId == userId);

            if (employee == null)
                return NotFound("Employee not found");

            var airport = _context.Airports.FirstOrDefault(a => a.AirportId == request.AirportId);
            if (airport == null)
                return NotFound("Airport not found");

            employee.AirportId = request.AirportId;

            _context.SaveChanges();

            return Ok(employee);
        }


    }
}
