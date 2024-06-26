using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EventHubApp.Entities;

public partial class EventHubussyContext : DbContext
{
    public EventHubussyContext()
    {
    }

    public EventHubussyContext(DbContextOptions<EventHubussyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<Organizer> Organizers { get; set; }

    public virtual DbSet<OrganizerEvent> OrganizerEvents { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserInformation> UserInformations { get; set; }

    public virtual DbSet<UserTicket> UserTickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CC1006-148\\SQLEXPRESS;Initial Catalog=EventHubussy;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;User ID=sa;Password=Kyntltn.3102");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Event1)
                .HasMaxLength(50)
                .HasColumnName("Event");
            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.EventType).WithMany(p => p.Events)
                .HasForeignKey(d => d.EventTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Events_EventTypes");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.HasKey(e => e.EventTypeId).HasName("PK_tblEventType");

            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.EventType1)
                .HasMaxLength(50)
                .HasColumnName("EventType");
        });

        modelBuilder.Entity<Organizer>(entity =>
        {
            entity.Property(e => e.OrganizerId).HasColumnName("OrganizerID");
            entity.Property(e => e.BusinessContactNumber).HasMaxLength(50);
            entity.Property(e => e.BusinessEmail).HasMaxLength(50);
            entity.Property(e => e.Headquarters).HasMaxLength(50);
            entity.Property(e => e.Organizer1)
                .HasMaxLength(50)
                .HasColumnName("Organizer");
        });

        modelBuilder.Entity<OrganizerEvent>(entity =>
        {
            entity.Property(e => e.OrganizerEventId).HasColumnName("OrganizerEventID");
            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.OrganizerId).HasColumnName("OrganizerID");

            entity.HasOne(d => d.Event).WithMany(p => p.OrganizerEvents)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizerEvents_Events");

            entity.HasOne(d => d.Organizer).WithMany(p => p.OrganizerEvents)
                .HasForeignKey(d => d.OrganizerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizerEvents_Organizers");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Ticket1)
                .HasMaxLength(50)
                .HasColumnName("Ticket");

            entity.HasOne(d => d.Event).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tickets_Events");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_tblUsers");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.OrganizerId).HasColumnName("OrganizerID");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(64)
                .IsFixedLength();
            entity.Property(e => e.Salt).HasMaxLength(50);
            entity.Property(e => e.UserInformationId).HasColumnName("UserInformationID");

            entity.HasOne(d => d.Organizer).WithMany(p => p.Users)
                .HasForeignKey(d => d.OrganizerId)
                .HasConstraintName("FK_Users_Organizers");

            entity.HasOne(d => d.UserInformation).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserInformationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_UserInformation");
        });

        modelBuilder.Entity<UserInformation>(entity =>
        {
            entity.ToTable("UserInformation");

            entity.Property(e => e.UserInformationId).HasColumnName("UserInformationID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
        });

        modelBuilder.Entity<UserTicket>(entity =>
        {
            entity.Property(e => e.UserTicketId).HasColumnName("UserTicketID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserTickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTickets_Tickets");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.UserTickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTickets_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
