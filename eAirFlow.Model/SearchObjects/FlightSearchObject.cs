using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class FlightSearchObject : BaseSearchObject
    {
        public string? DepartureLocation { get; set; }
        public string? ArrivalLocation { get; set; }
        public int? AirlineId { get; set; }
        public int? AirplaneId { get; set; }
        public bool? TodayOnly { get; set; }
        public DateTime? Date { get; set; }
    }
}
