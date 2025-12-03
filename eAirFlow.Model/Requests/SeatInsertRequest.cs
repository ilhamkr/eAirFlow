using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class SeatInsertRequest
    {
        public int? AirplaneId { get; set; }
        public string? SeatNumber { get; set; }
        public int? SeatClassId { get; set; }
    }
}
