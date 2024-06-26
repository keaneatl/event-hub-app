using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class OrganizerEvent
{
    public int OrganizerEventId { get; set; }

    public bool? ApprovalStatus { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public int Capacity { get; set; }

    public DateTime ApplicationDate { get; set; }

    public int EventId { get; set; }

    public int OrganizerId { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Organizer Organizer { get; set; } = null!;
}
