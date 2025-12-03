using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightReviewController : BaseCRUDController<FlightReview, FlightReviewSearchObject, FlightReviewInsertRequest, FlightReviewUpdateRequest>
    {
        public FlightReviewController(IFlightReviewService service) : base(service)
        {
        }
    }
}
