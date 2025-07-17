using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Services
{
    public interface IturnService
    {
        Task<List<Turn>> GetListAsync();
        Task<Turn> GetByIdAsync(int id);
        Task AddAsync(Turn value);
        Task PutAsync(int id, Turn value);
         Task DeleteAsync(int id);
        Task<Turn> UpdateAsync(int id, Turn turn);
    }
}
