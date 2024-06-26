using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHubApp.Migrations.EventHubussy
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "EventTypes",
            //    columns: table => new
            //    {
            //        EventTypeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EventType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tblEventType", x => x.EventTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Organizers",
            //    columns: table => new
            //    {
            //        OrganizerID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Organizer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Headquarters = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        BusinessEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        BusinessContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Organizers", x => x.OrganizerID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserInformation",
            //    columns: table => new
            //    {
            //        UserInformationID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserInformation", x => x.UserInformationID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Events",
            //    columns: table => new
            //    {
            //        EventID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Event = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Price = table.Column<decimal>(type: "money", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EventTypeID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Events", x => x.EventID);
            //        table.ForeignKey(
            //            name: "FK_Events_EventTypes",
            //            column: x => x.EventTypeID,
            //            principalTable: "EventTypes",
            //            principalColumn: "EventTypeID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        UserID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        PasswordHash = table.Column<byte[]>(type: "binary(64)", fixedLength: true, maxLength: 64, nullable: false),
            //        Salt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        UserInformationID = table.Column<int>(type: "int", nullable: false),
            //        OrganizerID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tblUsers", x => x.UserID);
            //        table.ForeignKey(
            //            name: "FK_Users_Organizers",
            //            column: x => x.OrganizerID,
            //            principalTable: "Organizers",
            //            principalColumn: "OrganizerID");
            //        table.ForeignKey(
            //            name: "FK_Users_UserInformation",
            //            column: x => x.UserInformationID,
            //            principalTable: "UserInformation",
            //            principalColumn: "UserInformationID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrganizerEvents",
            //    columns: table => new
            //    {
            //        OrganizerEventID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ApprovalStatus = table.Column<bool>(type: "bit", nullable: true),
            //        ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Capacity = table.Column<int>(type: "int", nullable: false),
            //        ApplicationDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EventID = table.Column<int>(type: "int", nullable: false),
            //        OrganizerID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrganizerEvents", x => x.OrganizerEventID);
            //        table.ForeignKey(
            //            name: "FK_OrganizerEvents_Events",
            //            column: x => x.EventID,
            //            principalTable: "Events",
            //            principalColumn: "EventID");
            //        table.ForeignKey(
            //            name: "FK_OrganizerEvents_Organizers",
            //            column: x => x.OrganizerID,
            //            principalTable: "Organizers",
            //            principalColumn: "OrganizerID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tickets",
            //    columns: table => new
            //    {
            //        TicketID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Ticket = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Price = table.Column<decimal>(type: "money", nullable: false),
            //        EventID = table.Column<int>(type: "int", nullable: false),
            //        Stock = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tickets", x => x.TicketID);
            //        table.ForeignKey(
            //            name: "FK_Tickets_Events",
            //            column: x => x.EventID,
            //            principalTable: "Events",
            //            principalColumn: "EventID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTickets",
            //    columns: table => new
            //    {
            //        UserTicketID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PurchaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        TicketID = table.Column<int>(type: "int", nullable: false),
            //        UserID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTickets", x => x.UserTicketID);
            //        table.ForeignKey(
            //            name: "FK_UserTickets_Tickets",
            //            column: x => x.UserID,
            //            principalTable: "Tickets",
            //            principalColumn: "TicketID");
            //        table.ForeignKey(
            //            name: "FK_UserTickets_Users",
            //            column: x => x.UserID,
            //            principalTable: "Users",
            //            principalColumn: "UserID");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Events_EventTypeID",
            //    table: "Events",
            //    column: "EventTypeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrganizerEvents_EventID",
            //    table: "OrganizerEvents",
            //    column: "EventID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrganizerEvents_OrganizerID",
            //    table: "OrganizerEvents",
            //    column: "OrganizerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tickets_EventID",
            //    table: "Tickets",
            //    column: "EventID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_OrganizerID",
            //    table: "Users",
            //    column: "OrganizerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_UserInformationID",
            //    table: "Users",
            //    column: "UserInformationID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserTickets_UserID",
            //    table: "UserTickets",
            //    column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizerEvents");

            migrationBuilder.DropTable(
                name: "UserTickets");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "EventTypes");
        }
    }
}
