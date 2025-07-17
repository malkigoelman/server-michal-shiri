using Microsoft.EntityFrameworkCore;
using smr.Core.Repositories;
using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Data.Repositories
{
    public class renterRepository : IrenterRepository
    {
        private readonly DataContext _context;

        public renterRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Renter>> GetAllAsync()
        {

            return await _context.renters.Include(r => r.turns).ToListAsync();
        }
        public async Task<Renter> GetByIdAsync(int id)
        {
            return await _context.renters.FirstOrDefaultAsync(x => x.id == id);
        }
        public async Task AddAsync(Renter value)
        {
            _context.renters.Add(value);

            await _context.SaveChangesAsync();
        }

        public async Task PutAsync(Renter value)
        {
            var renter = await _context.renters.FirstOrDefaultAsync(x => x.id == value.id);
            renter.id = value.id;
            renter.CountryNameOfBusiness = value.CountryNameOfBusiness;
            renter.isActive = value.isActive;
            await _context.SaveChangesAsync();
        }
        public async Task PutStatusAsync(int id, bool isActive)
        {
            var renter = await _context.renters.FirstOrDefaultAsync(x => x.id == id);
            renter.isActive = isActive;
            await _context.SaveChangesAsync();

        }
        public async Task<Renter> UpdateAsync(int id, Renter newRenter)
        {
            var renters = await _context.renters.ToListAsync();
           var index = renters.FindIndex(x => x.id == id);
            if (index != -1)
            {
                renters[index].CountryNameOfBusiness = newRenter.CountryNameOfBusiness;
                renters[index].isActive = newRenter.isActive;
                await _context.SaveChangesAsync();
                return renters[index];
            }
            return null;
        }
    }
}
