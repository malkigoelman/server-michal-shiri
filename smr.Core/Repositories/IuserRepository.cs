using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using global::smr.Core.Entitis.smr.Core.Models;
//using smr.Core.Models;

    namespace smr.Core.Repositories
    {
        public interface IuserRepository
        {
            Task<User> AddUserAsync(User user);
        Task<User?> GetByUserNameAsync(string userName, string password);
        }
    }


