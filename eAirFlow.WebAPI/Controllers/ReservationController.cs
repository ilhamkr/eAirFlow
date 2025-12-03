using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using eAirFlow.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : BaseCRUDController<Model.Models.Reservation, ReservationSearchObject, ReservationInsertRequest, ReservationUpdateRequest>
    {
        private readonly IReservationService _reservationService;
        private readonly _210019Context _context;
        public ReservationController(IReservationService service, _210019Context context) : base(service)
        {
            _reservationService = service;
            _context = context;
        }

        [HttpGet("occupied/{flightId}")]
        public IActionResult GetOccupied(int flightId)
        {
            var seats = _context.Reservations
                .Where(r => r.FlightId == flightId)
                .Select(r => r.Seat!.SeatNumber)
                .ToList();

            return Ok(seats);
        }


        [HttpPut("{id}/confirm")]
        public IActionResult Confirm(int id)
        {
            var result = _reservationService.Confirm(id);
            return Ok(result);
        }

        [HttpPut("{id}/cancel")]
        public IActionResult Cancel(int id)
        {
            var result = _reservationService.Cancel(id);
            return Ok(result);
        }

        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            var result = _reservationService.Complete(id);
            return Ok(result);
        }

        [HttpPut("{id}/pay")]
        public ActionResult<Model.Models.Reservation> Pay(int id, [FromQuery] int paymentId)
        {
            return Ok(_reservationService.MarkAsPaid(id, paymentId));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _reservationService.Delete(id);
            return Ok();
        }


        [HttpGet("user/{userId}")]
        public IActionResult GetByUser(int userId)
        {
            var result = _reservationService.GetByUser(userId);
            return Ok(result);
        }


    }
}
