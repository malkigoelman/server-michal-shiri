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
        Task<Tourist> GetByIdAsync(string id);
        Task AddAsync(Tourist value);
      Task< Tourist> PutAsync(string id, Tourist value);
        Task PutStatusAsync(string id, bool isActive);
    Task <Tourist> UpdateAsync(string id, Tourist newTouirst);
    }
}
