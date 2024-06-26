using EventHubApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventHubApp.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventHubussyContext _context;
        public EventsService(EventHubussyContext context)
        {
            _context = context; 
        }

        public async Task<List<Event>> GetAllEvents()
        {
            var events = await _context.Events.ToListAsync();
            return events;
        }

        public async Task<Event> GetEvent(string id)
        {
            int eventId = int.Parse(id.Trim('{').Trim('}'));
            
            var e = await _context.Events.FindAsync(eventId);

            return e;
        }
    }
}
