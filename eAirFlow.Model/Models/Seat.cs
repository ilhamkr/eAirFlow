using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Seat
    {
        public int SeatId { get; set; }

        public int? AirplaneId { get; set; }

        public string? SeatNumber { get; set; }

        public int? SeatClassId { get; set; }

    }
}
