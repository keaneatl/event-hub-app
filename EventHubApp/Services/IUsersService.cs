using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public interface IUsersService
    {
        Task<User> AddUser(User user);
        Task<User> FindUserByUsername(string username);
    }
}
