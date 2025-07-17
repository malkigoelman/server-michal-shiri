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
    public class renterService : IrenterService

    {
        private readonly IrenterRepository _renterRepository;

        public renterService(IrenterRepository renterRepository)
        {
            _renterRepository = renterRepository;
        }

        public async Task<List<Renter>> GetListAsync()
        {
            return await _renterRepository.GetAllAsync();
        }
        public async Task< Renter> GetByIdAsync(int id)
        {
            return  await _renterRepository.GetByIdAsync(id);
        }
        public async Task AddAsync(Renter value)
        {
           await  _renterRepository.AddAsync(value);
        }
        public async Task PutAsync(Renter value)
        {
           await _renterRepository.PutAsync(value);
        }
        public async Task PutStatusAsync(int id, bool isActive)
        {
          await  _renterRepository.PutStatusAsync(id, isActive);
        }
        public  async  Task<Renter> UpdateAsync(int id,Renter renter)
        {
            
          return  await _renterRepository.UpdateAsync(id, renter);
           
        }
    }
}


