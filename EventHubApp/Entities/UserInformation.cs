using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class UserInformation
{
    public int UserInformationId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
