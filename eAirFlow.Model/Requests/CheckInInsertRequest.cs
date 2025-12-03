using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class CheckInInsertRequest
    {
        public int? ReservationId { get; set; }
        public int? SeatId { get; set; }
        public DateTime? CheckinTime { get; set; }
        public int? UserId { get; set; }
    }
}
