using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Repositories
{
    public interface IturnRepository
    {
        Task<List<Turn>> GetAllAsync();
        Task<Turn> GetByIdAsync(string id);
         Task AddAsync(Turn value);
        Task PutAsync(string id, Turn value);
   Task DeleteAsync(string id);
          Task<Turn> UpdateAsync(string id, Turn newTurn);
    }
}
