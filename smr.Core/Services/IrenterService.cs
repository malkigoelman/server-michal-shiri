using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Services
{
    public interface IrenterService
    {
        Task<List<Renter>> GetListAsync();
        Task<Renter> GetByIdAsync(int id);
        public Task AddAsync(Renter value);
        Task PutAsync(Renter value);
        Task PutStatusAsync(int id, bool isActive);
         Task<Renter> UpdateAsync (int id, Renter renter);
    }
   
      
}
