using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public interface ITicketsService
    {
        Task<List<Ticket>> GetAllTickets();
        Task<List<Ticket>> GetEventTickets(string eventId);
    }
}
