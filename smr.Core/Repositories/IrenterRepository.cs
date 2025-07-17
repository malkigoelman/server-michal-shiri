using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Repositories
{
    public interface IrenterRepository
    {
         Task<List<Renter>> GetAllAsync();
        Task<Renter> GetByIdAsync(int id);
          Task  AddAsync(Renter value);
        Task PutAsync(Renter value);
        Task PutStatusAsync(int id, bool isActive);
        Task<Renter> UpdateAsync(int id, Renter newRenter);
    }
}
