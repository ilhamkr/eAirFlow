using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class UserRole
{
    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}
