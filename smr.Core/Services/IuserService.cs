using smr.Core.Entitis.smr.Core.Models;

namespace smr.Core.Services
{
    public interface IuserService
    {
        Task<User?> GetUserByUserNameAsync(string userName, string password);
        Task<User> AddUserAsync(User user);
    }
}
