using smr.Core.Entitis.smr.Core.Models;
using System.Threading.Tasks;

namespace smr.Core.Services
{
    public interface IuserService
    {
        Task<User?> GetUserByUserNameAsync(string userName, string password);
        Task<User?> GetUserByCredentialsAsync(int id, string username, string password);
        Task<User> AddUserAsync(User user);
    }
}
