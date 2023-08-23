using System;
using System.Collections.Generic;

namespace ManageStaff.Models;

public partial class Staff
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public string AccessLevel { get; set; } = null!;
}
