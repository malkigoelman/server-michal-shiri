using smr.Core.Entitis.smr.Core.Models;
using System.Threading.Tasks;

namespace smr.Core.Repositories
{
    public interface IuserRepository
    {
        Task<User> AddUserAsync(User user);
        Task<User?> GetByUserNameAsync(string userName, string password);
        Task<User?> GetByCredentialsAsync(int id, string userName, string password);
    }
}
