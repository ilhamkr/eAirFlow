using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class AirportSearchObject : BaseSearchObject
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
