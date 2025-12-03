using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eAirFlow.Services.Database;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? HireDate { get; set; }

    public int? PositionId { get; set; }
    public int? AirportId { get; set; }
    public virtual Airport? Airport { get; set; }
    public int? UserId { get; set; }

    [JsonIgnore]
    public User? User { get; set; }

    public virtual ICollection<LuggageReport> LuggageReports { get; set; } = new List<LuggageReport>();

    public virtual Position? Position { get; set; }
}
