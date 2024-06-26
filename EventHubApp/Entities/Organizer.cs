using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class Organizer
{
    public int OrganizerId { get; set; }

    public string Organizer1 { get; set; } = null!;

    public string Headquarters { get; set; } = null!;

    public string BusinessEmail { get; set; } = null!;

    public string BusinessContactNumber { get; set; } = null!;

    public virtual ICollection<OrganizerEvent> OrganizerEvents { get; set; } = new List<OrganizerEvent>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
