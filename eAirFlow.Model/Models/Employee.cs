using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Employee
    {
        public int EmployeeId { get; set; }
        public int? UserId { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? HireDate { get; set; }

        public Position? Position { get; set; }
        public int? PositionId { get; set; }
        public int? AirportId { get; set; }
        public Airport? Airport { get; set; }


    }
}
