using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class EmployeeSearchObject : BaseSearchObject
    {
        public string? NameGTE { get; set; }
        public string? SurnameGTE { get; set; }
        public string? Email { get; set; }
    }
}
