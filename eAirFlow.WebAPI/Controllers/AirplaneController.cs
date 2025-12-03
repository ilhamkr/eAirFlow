using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirplaneController : BaseCRUDController<Airplane, AirplaneSearchObject, AirplaneInsertRequest, AirplaneUpdateRequest>
    {
        private readonly IAirplaneService airplaneService;
        public AirplaneController(IAirplaneService airplaneService) : base(airplaneService)
        {
        }
    }
}
