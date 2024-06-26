using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class UserTicket
{
    public int UserTicketId { get; set; }

    public DateTime PurchaseDate { get; set; }

    public int Quantity { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? Description { get; set; }

    public int TicketId { get; set; }

    public int UserId { get; set; }

    public virtual Ticket User { get; set; } = null!;

    public virtual User UserNavigation { get; set; } = null!;
}
