using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class AirplaneInsertRequest
    {
        public string Model {  get; set; }
        public int? TotalSeats { get; set; }
        public int? AirlineId { get; set; }
    }
}
