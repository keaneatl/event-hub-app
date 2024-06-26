using EventHubApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventHubApp.Services
{
    public class UserTicketsService : IUserTicketsService
    {
        private readonly EventHubussyContext _context;

        public UserTicketsService(EventHubussyContext context)
        {
            _context = context;
        }

        public async Task<UserTicket> PurchaseTicket(UserTicket ticket)
        {
            // Add ticket to user purchases
            _context.UserTickets.Add(ticket);

            // Reduce ticket quantity
            var ticketToReduce = await _context.Tickets.FindAsync(ticket.TicketId);

            ticketToReduce.Stock -= 1;
            
            await _context.SaveChangesAsync();

            return ticket;
        }
    }
}
