
using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class CaptureOrderRequest
    {
        public string OrderId { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }

    }
}
