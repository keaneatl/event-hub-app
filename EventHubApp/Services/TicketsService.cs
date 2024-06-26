using EventHubApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventHubApp.Services
{
    public class TicketsService : ITicketsService
    {
        private readonly EventHubussyContext _context;
        public TicketsService(EventHubussyContext context)
        {
            _context = context;
        }

        public async Task<List<Ticket>> GetAllTickets()
        {
            var tickets = await _context.Tickets.ToListAsync();
            return tickets;
        }
        public async Task<List<Ticket>> GetEventTickets(string eventId)
        {
            int eId = int.Parse(eventId.Trim('{').Trim('}'));
            var tickets = await _context.Tickets.ToListAsync();
            
            var eventTickets = tickets.FindAll(ticket => ticket.EventId == eId);

            return eventTickets;
        }

    }
}
