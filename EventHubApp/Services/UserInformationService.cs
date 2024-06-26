using EventHubApp.Entities;

namespace EventHubApp.Services
{
    public class UserInformationService : IUserInformationService
    {
        private readonly EventHubussyContext _context;
        public UserInformationService(EventHubussyContext context)
        {
            _context = context;
        }

        public async Task<UserInformation> AddUserInformation(UserInformation userInformation)
        {
            _context.UserInformations.Add(userInformation);
            await _context.SaveChangesAsync();

            return userInformation;
        }
    }
}
