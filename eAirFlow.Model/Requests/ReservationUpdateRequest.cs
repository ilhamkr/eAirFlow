using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class ReservationUpdateRequest
    {
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public DateTime? ReservationDate { get; set; }
        public int? PaymentId { get; set; }
    }
}
