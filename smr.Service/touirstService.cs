using smr.Core.Repositories;
using smr.Core.Services;
using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Service
{
    public class touirstService : ItouirstService
    {
        private readonly ItouirstRepository _touirstRepository;

        public touirstService(ItouirstRepository touirstRepository)
        {
            _touirstRepository = touirstRepository;
        }

        public async Task<List<Tourist>> GetListAsync()
        {
            return await _touirstRepository.GetAllAsync();
        }
        public async Task<Tourist> GetByIdAsync(int id)
        {
            return await _touirstRepository.GetByIdAsync(id);
        }
        public async Task AddAsync(Tourist value)
        {
           await _touirstRepository.AddAsync(value);
        }
        public async Task<Tourist> PutAsync(int id,Tourist value)
        {
           return  await _touirstRepository.PutAsync(id,value);
        }
        public async Task PutStatusAsync(int id, bool isActive)
        {
             await _touirstRepository.PutStatusAsync(id, isActive);
        }

        public async Task<Tourist> UpdateAsync(int id, Tourist touirst)
        {
            return  await _touirstRepository.UpdateAsync(id, touirst);
        }
    }
}

