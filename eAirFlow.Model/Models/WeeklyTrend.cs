using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Models
{
    public class WeeklyTrend
    {
        public string Day { get; set; }
        public int Completed { get; set; }
        public int Canceled { get; set; }
        public int Delayed { get; set; }
    }
}
