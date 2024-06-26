using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHubApp.Migrations.EventHubussy
{
    /// <inheritdoc />
    public partial class EditUserTicketsRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTickets_Tickets",
                table: "UserTickets");

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_TicketID",
                table: "UserTickets",
                column: "TicketID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTickets_Tickets",
                table: "UserTickets",
                column: "TicketID",
                principalTable: "Tickets",
                principalColumn: "TicketID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTickets_Tickets",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_TicketID",
                table: "UserTickets");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTickets_Tickets",
                table: "UserTickets",
                column: "UserID",
                principalTable: "Tickets",
                principalColumn: "TicketID");
        }
    }
}
