using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? ProfileImageUrl { get; set; }
        public int? EmployeeId { get; set; }

        public Employee? Employee { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
