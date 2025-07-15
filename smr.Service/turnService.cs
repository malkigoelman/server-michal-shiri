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
    public class turnService : IturnService
    {
        private readonly IturnRepository _turnRepository;

        public turnService(IturnRepository turnRepository)
        {
            _turnRepository = turnRepository;
        }

        public async Task <List<Turn>> GetListAsync()
        {
            return await  _turnRepository.GetAllAsync();
        }
        public async   Task<Turn> GetByIdAsync(string id)
        {
            return await _turnRepository.GetByIdAsync(id);
        }
        public async Task AddAsync(Turn value)
        {
           await  _turnRepository.AddAsync(value);
        }
        public async Task PutAsync(string id, Turn value)
        {
           await _turnRepository.PutAsync(id, value);
        }
        public async Task DeleteAsync(string id)
        {
           await _turnRepository.DeleteAsync(id);
        }
        public async Task< Turn> UpdateAsync(string id, Turn turn)
        {
            return await _turnRepository.UpdateAsync(id, turn);
        }
    }
}
