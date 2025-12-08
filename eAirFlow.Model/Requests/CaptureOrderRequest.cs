
using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class CaptureOrderRequest
    {
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public int FlightId { get; set; }
        public int SeatId { get; set; }
        public int MealTypeId { get; set; }
        public string SelectedSeat { get; set; }
        public int AirportId { get; set; }
        public int AirplaneId { get; set; }

    }
}
