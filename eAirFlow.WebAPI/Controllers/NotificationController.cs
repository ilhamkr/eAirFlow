using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : BaseCRUDController<Notification, NotificationSearchObject, NotificationInsertRequest, NotificationUpdateRequest>
    {
        public NotificationController(INotificationService service) : base(service)
        {
        }

        [HttpGet("unseen/{userId}")]
        public IActionResult GetUnseen(int userId)
        {
            var result = _service.GetPaged(new NotificationSearchObject
            {
                UserId = userId,
                UnreadOnly = true
            });

            return Ok(result);
        }

        [HttpPut("seen/{id}")]
        public IActionResult MarkSeen(int id)
        {
            var item = _service.Update(id, new NotificationUpdateRequest
            {
                IsSeen = true
            });

            return Ok(item);
        }

    }
}
