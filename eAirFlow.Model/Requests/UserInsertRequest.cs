using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class UserInsertRequest
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public string Password { get; set; } = null!;
        public string PasswordConfirmation { get; set; } = null!;
        public int RoleId { get; set; } = 1;

    }
}
