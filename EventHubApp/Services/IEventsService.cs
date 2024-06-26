using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public interface IEventsService
    {
        Task<List<Event>> GetAllEvents();
        Task<Event> GetEvent(string id);
    }
}
