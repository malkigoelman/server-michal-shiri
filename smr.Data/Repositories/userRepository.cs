using Microsoft.EntityFrameworkCore;
using smr.Core.Entitis.smr.Core.Models;
using smr.Core.Repositories;
using System.Threading.Tasks;

namespace smr.Data.Repositories
{
    public class UserRepository : IuserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User?> GetByCredentialsAsync(int id, string userName, string password)
        {
            return await _dataContext.Users
                .FirstOrDefaultAsync(u => u.Id == id && u.UserName == userName && u.Password == password);
        }

        public async Task<User?> GetByUserNameAsync(string userName, string password)
        {
            return await _dataContext.Users
                .FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password);
        }

        public async Task<User> AddUserAsync(User user)
        {
            var existingUser = await _dataContext.Users
                .FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);

            if (existingUser == null)
            {
                _dataContext.Users.Add(user);
                await _dataContext.SaveChangesAsync();
                return user;
            }

            return null;
        }
    }
}
