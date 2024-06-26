using EventHubApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventHubApp.Services
{
    public class UsersService : IUsersService
    {
        private readonly EventHubussyContext _context;

        public UsersService(EventHubussyContext context)
        {
            _context = context;
        }

        public async Task<User> AddUser(User user)
        {
           _context.Users.Add(user);
            await _context.SaveChangesAsync();

            //await _context.Database.OpenConnectionAsync();
            //try
            //{
            //    await _context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT dbo.EventHubussy ON");
            //    await _context.SaveChangesAsync();
            //    await _context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT dbo.EventHubussy OFF");
            //}
            //finally
            //{
            //    await _context.Database.OpenConnectionAsync();
            //}

            return user;
        }

        public async Task<User> FindUserByUsername(string username)
        {
            var users = await _context.Users.ToListAsync();
            var user = users.Find(user => user.Username == username);

            return user;
        }
    }
}
