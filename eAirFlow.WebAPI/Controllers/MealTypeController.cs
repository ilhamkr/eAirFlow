using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealTypeController : BaseCRUDController<MealType,MealTypeSearchObject,MealTypeInsertRequest,MealTypeUpdateRequest>
    {
        public MealTypeController(IMealTypeService service) : base(service)
        {
        }

        
    }

}
