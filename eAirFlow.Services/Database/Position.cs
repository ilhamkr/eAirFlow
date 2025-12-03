using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAirFlow.Services.Database;

public partial class Position
{
    public int PositionId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    [JsonIgnore]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
