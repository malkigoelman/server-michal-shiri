using smr.Core.Entitis.smr.Core.Models;
using smr.Core.Repositories;
using smr.Core.Services;
using System.Threading.Tasks;

namespace smr.Service
{
    public class UserService : IuserService
    {
        private readonly IuserRepository _userRepository;

        public UserService(IuserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserByCredentialsAsync(int id, string username, string password)
        {
            return await _userRepository.GetByCredentialsAsync(id, username, password);
        }

        public async Task<User?> GetUserByUserNameAsync(string userName, string password)
        {
            return await _userRepository.GetByUserNameAsync(userName, password);
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddUserAsync(user);
        }
    }
}
