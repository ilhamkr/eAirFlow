using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Database
{
    public class TimeZone
    {
        public string TimeZoneId { get; set; }
        public string DisplayName { get; set; }
        public virtual ICollection<Airport> Airports { get; set; } = new List<Airport>();
    }
}
