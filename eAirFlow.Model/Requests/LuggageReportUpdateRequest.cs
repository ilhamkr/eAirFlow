using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class LuggageReportUpdateRequest
    {
        public int? LuggageId { get; set; }
        public int? EmployeeId { get; set; }
        public string? ReportType { get; set; }
        public DateTime? ReportTime { get; set; }
        public string? Notes { get; set; }
    }
}
