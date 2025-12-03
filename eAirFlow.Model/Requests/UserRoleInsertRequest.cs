using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class UserRoleInsertRequest
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
