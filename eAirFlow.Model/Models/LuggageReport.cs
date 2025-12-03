using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public partial class LuggageReport
    {
        public int ReportId { get; set; }

        public int? LuggageId { get; set; }

        public int? EmployeeId { get; set; }

        public string? ReportType { get; set; }

        public DateTime? ReportTime { get; set; }

        public string? Notes { get; set; }

    }
}
