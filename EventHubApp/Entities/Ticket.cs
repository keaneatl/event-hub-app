using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class Ticket
{
    public int TicketId { get; set; }

    public string Ticket1 { get; set; } = null!;

    public decimal Price { get; set; }

    public int EventId { get; set; }

    public int Stock { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual ICollection<UserTicket> UserTickets { get; set; } = new List<UserTicket>();
}
