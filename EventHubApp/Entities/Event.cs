using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class Event
{
    public int EventId { get; set; }

    public string Event1 { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int EventTypeId { get; set; }

    public virtual EventType EventType { get; set; } = null!;

    public virtual ICollection<OrganizerEvent> OrganizerEvents { get; set; } = new List<OrganizerEvent>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
