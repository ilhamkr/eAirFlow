using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Airplane
    {
        public int AirplaneId { get; set; }

        public string? Model { get; set; }

        public int? TotalSeats { get; set; }
        public int? AirlineId { get; set; }

    }
}