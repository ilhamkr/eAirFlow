using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eAirFlow.Model.Messages;
using System.IO;
using eAirFlow.Services.RabbitMQ;
using Microsoft.AspNetCore.Identity.Data;
using eAirFlow.Services.Recommender;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseCRUDController<Model.Models.User, UserSearchObjects, UserInsertRequest, UserUpdateRequest>
    {
        private readonly IUserService _userService;
        private readonly _210019Context _context;
        private readonly IRabbitMQService _rabbitMq;
        private readonly IFlightRecommenderService _recommender;

        public UserController(IUserService userService,
                              _210019Context context,
                              IRabbitMQService rabbitMq,
                              IFlightRecommenderService recommender)
            : base(userService)
        {
            _userService = userService;
            _context = context;
            _rabbitMq = rabbitMq;
            _recommender = recommender;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserInsertRequest request)
        {
            try
            {
                var user = await _userService.RegisterAsync(request);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] Model.Requests.LoginRequest request)
        {
            var user = _userService.Login(request.Email, request.Password);

            if (user == null)
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(user);
        }

        [HttpGet("recommender/{userId}")]
        public ActionResult<List<Model.Models.Flight>> GetForUser(int userId, [FromQuery] int count = 3)
        {
            var result = _recommender.GetRecommendedFlights(userId, count);
            return Ok(result);
        }

        [HttpPost("{id}/upload-profile")]
        public async Task<IActionResult> UploadProfileImage(int id, [FromForm] ProfileImageUploadRequest request)
        {
            if (request.File == null || request.File.Length == 0)
                return BadRequest("Invalid file");

            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound("User not found");

            var folder = Path.Combine("wwwroot", "profile");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(request.File.FileName)}";
            var filePath = Path.Combine(folder, fileName);

            using var stream = System.IO.File.Create(filePath);
            await request.File.CopyToAsync(stream);

            user.ProfileImageUrl = $"/profile/{fileName}";
            await _context.SaveChangesAsync();

            return Ok(user.ProfileImageUrl);
        }

        [AllowAnonymous]
        [HttpGet("confirm/{token}")]
        public async Task<IActionResult> ConfirmEmail(string token)
        {
            var confirmation = await _context.EmailConfirmations
                .FirstOrDefaultAsync(x => x.Token == token);

            if (confirmation == null)
                return BadRequest("Invalid token");

            if (confirmation.IsConfirmed)
                return BadRequest("Email already confirmed");

            confirmation.IsConfirmed = true;
            await _context.SaveChangesAsync();

            return Ok("Email confirmed successfully!");
        }

        [AllowAnonymous]
        [HttpPost("resend-confirmation")]
        public async Task<IActionResult> ResendConfirmation([FromBody] ResendConfirmationRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (user == null)
                return NotFound("User not found");

            var confirmation = await _context.EmailConfirmations
                .FirstOrDefaultAsync(x => x.UserId == user.UserId);

            if (confirmation == null)
                return NotFound("No confirmation token exists for this user");

            if (confirmation.IsConfirmed)
                return BadRequest("Email already confirmed");

            await _rabbitMq.SendEmail(new Email
            {
                EmailTo = user.Email!,
                ReceiverName = user.Name ?? "User",
                Subject = "Confirm your eAirFlow email",
                Message = $@"
                    <h2>Confirm your email again</h2>
                    <p>Click the link below:</p>
                    <a href='https://localhost:7239/User/confirm/{confirmation.Token}'>
                        Confirm Email
                    </a>"
            });

            return Ok("Confirmation email sent again.");
        }

        [HttpPut("change-role/{userId}")]
        public IActionResult ChangeRole(int userId, [FromBody] ChangeRoleRequest request)
        {
            var existing = _context.UserRoles.FirstOrDefault(x => x.UserId == userId);

            if (existing == null)
            {
                existing = new eAirFlow.Services.Database.UserRole
                {
                    UserId = userId,
                    RoleId = 1
                };
                _context.UserRoles.Add(existing);
                _context.SaveChanges();
            }

            _context.UserRoles.Remove(existing);
            _context.SaveChanges();

            var newRole = new eAirFlow.Services.Database.UserRole
            {
                UserId = userId,
                RoleId = request.RoleId
            };
            _context.UserRoles.Add(newRole);
            _context.SaveChanges();

            if (request.RoleId == 2)
            {
                var user = _context.Users.FirstOrDefault(x => x.UserId == userId);

                var existingEmp = _context.Employees.FirstOrDefault(e => e.UserId == userId);
                if (existingEmp == null)
                {
                    var emp = new eAirFlow.Services.Database.Employee
                    {
                        UserId = userId,
                        Name = user.Name,
                        Surname = user.Surname,
                        Email = user.Email,
                        HireDate = DateTime.Now,
                        PositionId = null
                    };

                    _context.Employees.Add(emp);
                    _context.SaveChanges();
                }
            }

            return Ok(newRole);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var ok = await _userService.DeleteUserAsync(id);

            if (!ok)
                return NotFound(false);

            return Ok(true);
        }


    }
}
