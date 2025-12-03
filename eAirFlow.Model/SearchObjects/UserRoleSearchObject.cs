using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class UserRoleSearchObject : BaseSearchObject
    {
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
    }
}
