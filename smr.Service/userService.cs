using smr.Core.Entitis.smr.Core.Models;
using smr.Core.Repositories;
using smr.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace smr.Service
{
    public class userService : IuserService
    {
        private readonly IuserRepository _userRepository;

        public userService(IuserRepository userRepository)
        {
            _userRepository = userRepository;
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
