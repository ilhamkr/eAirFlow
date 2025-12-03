using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class AssignEmployeeRequest
    {
        public int UserId { get; set; }
        public int PositionId { get; set; }
        public int AirportId { get; set; }
    }
}
