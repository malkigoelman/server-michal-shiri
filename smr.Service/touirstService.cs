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
        public async Task<Tourist> GetByIdAsync(string id)
        {
            return await _touirstRepository.GetByIdAsync(id);
        }
        public async Task AddAsync(Tourist value)
        {
           await _touirstRepository.AddAsync(value);
        }
        public async Task<Tourist> PutAsync(string id,Tourist value)
        {
           return  await _touirstRepository.PutAsync(id,value);
        }
        public async Task PutStatusAsync(string id, bool isActive)
        {
             await _touirstRepository.PutStatusAsync(id, isActive);
        }

        public async Task<Tourist> UpdateAsync(string id, Tourist touirst)
        {
            return  await _touirstRepository.UpdateAsync(id, touirst);
        }
    }
}

