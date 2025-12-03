using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class FlightIssueInsertRequest
    {
        public int? FlightId { get; set; }
        public int? ReportedBy { get; set; }
        public string? Description { get; set; }
        public DateTime? ReportedAt { get; set; }
    }
}
