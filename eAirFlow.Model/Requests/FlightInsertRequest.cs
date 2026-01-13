using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class FlightInsertRequest
    {
        public string? DepartureLocation { get; set; }
        public string? ArrivalLocation { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string? DepartureTimeZone { get; set; }
        public string? ArrivalTimeZone { get; set; }
        public int? AirlineId { get; set; }
        public int? Price { get; set; }

    }
}
