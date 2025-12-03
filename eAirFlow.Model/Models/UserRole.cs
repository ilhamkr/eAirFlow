using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{
    public class UserRole
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }

}
