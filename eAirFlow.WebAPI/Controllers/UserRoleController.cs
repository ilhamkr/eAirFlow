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
    public class UserRoleController : ControllerBase
    {
        private readonly _210019Context _context;
        public UserRoleController(_210019Context context)
        {
            _context = context;
        }
    }
}
