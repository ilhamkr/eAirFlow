using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class UserRoleUpdateRequest
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
