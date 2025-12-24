using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Database
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TimeZoneId { get; set; }

        public virtual ICollection<Airline> Airlines { get; set; } = new List<Airline>();
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
