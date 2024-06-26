using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public interface IEventTypesService
    {
        public Task<List<EventType>> GetAllEventTypes();
    }
}
