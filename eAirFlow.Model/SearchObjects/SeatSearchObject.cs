using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class SeatSearchObject : BaseSearchObject
    {
        public int? AirplaneId { get; set; }
        public int? SeatClassId { get; set; }
    }
}
