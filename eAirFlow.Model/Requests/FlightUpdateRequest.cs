using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class FlightUpdateRequest
    {
        public string? DepartureLocation { get; set; }
        public string? ArrivalLocation { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int? AirlineId { get; set; }
        public int? AirplaneId { get; set; }
        public int? Price { get; set; }
    }
}
