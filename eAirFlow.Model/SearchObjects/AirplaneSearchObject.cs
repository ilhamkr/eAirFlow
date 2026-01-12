using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class AirplaneSearchObject : BaseSearchObject
    {
        public string? ModelGTE {  get; set; }
        public int? AirlineId { get; set; }
        public bool? UnassignedOnly { get; set; }
    }
}
