using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using smr.Core.Entitis.smr.Core.Models;
using smr.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Data.Repositories
{
    public class userRepository : IuserRepository
    { private readonly DataContext _dataContext;


        public userRepository(DataContext dataContext) {  _dataContext = dataContext; }
        public async Task<User?> GetByUserNameAsync(string userName,string password)
        {

            return await _dataContext.users.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password);
        }
        public async Task<User> AddUserAsync(User user)
        {


            user =  await _dataContext.users.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
            if (user == null)
            {
                _dataContext.users.Add(user);
                await _dataContext.SaveChangesAsync();
                return user;
            }
            return null;
        }

    }
}


