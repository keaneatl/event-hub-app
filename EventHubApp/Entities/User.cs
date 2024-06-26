using System;
using System.Collections.Generic;

namespace EventHubApp.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public byte[] PasswordHash { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public int UserInformationId { get; set; }

    public int? OrganizerId { get; set; }

    public virtual Organizer? Organizer { get; set; }

    public virtual UserInformation UserInformation { get; set; } = null!;

    public virtual ICollection<UserTicket> UserTickets { get; set; } = new List<UserTicket>();
}
