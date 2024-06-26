using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public interface IUserTicketsService
    {
        Task<UserTicket> PurchaseTicket(UserTicket ticket);
        Task<List<UserTicket>> GetUserTicketsOfUser(int userId);
    }
}
