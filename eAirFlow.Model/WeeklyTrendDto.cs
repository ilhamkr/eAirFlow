using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model
{
    public class WeeklyTrendDto
    {
        public string Day { get; set; } = "";
        public int Completed { get; set; }
        public int Canceled { get; set; }
        public int Delayed { get; set; }
    }
}
