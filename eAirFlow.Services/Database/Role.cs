using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Role
{
    public int RoleId { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
