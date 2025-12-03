using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class LuggageReportSearchObject : BaseSearchObject
    {
        public int? LuggageId { get; set; }
        public int? EmployeeId { get; set; }
        public string? ReportType { get; set; }
    }
}
