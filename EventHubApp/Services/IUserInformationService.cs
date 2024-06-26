using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public interface IUserInformationService
    {
        Task<UserInformation> AddUserInformation(UserInformation userInformation);
    }
}
