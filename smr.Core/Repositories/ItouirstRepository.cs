using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Repositories
{
    public interface ItouirstRepository
    {
        Task<List<Tourist>> GetAllAsync();
        Task<Tourist> GetByIdAsync(int id);
        Task AddAsync(Tourist value);
      Task< Tourist> PutAsync(int id, Tourist value);
        Task PutStatusAsync(int id, bool isActive);
    Task <Tourist> UpdateAsync(int id, Tourist newTouirst);
    }
}
