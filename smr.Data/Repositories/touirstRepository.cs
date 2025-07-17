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
    public class touirstRepository:ItouirstRepository
    {
        private readonly DataContext _context;

        public touirstRepository(DataContext context)
        {
            _context = context;
        }
        public  async Task<List<Tourist>> GetAllAsync()
        {
            return  await _context.tourists.Include(s=>s.turns).ToListAsync();
        }


        public async Task< Tourist> GetByIdAsync(int id)
        {
          return  await _context.tourists.FirstOrDefaultAsync(x => x.id == id);
           // await  _context.SaveChangesAsync();
          
        }
        public async Task AddAsync(Tourist value)
        {
          await  _context.tourists.AddAsync(value);
         await   _context.SaveChangesAsync();
        }

        public async   Task<Tourist>  PutAsync(int id,Tourist value)
        {
            var Tourist_list = await _context.tourists.ToListAsync();
            var index = Tourist_list.FindIndex(x => x.id == id);    
            Tourist_list[index].CountryNameOfBusiness = value.CountryNameOfBusiness;
         
          await  _context.SaveChangesAsync();
            return Tourist_list[index];
        }
        public async Task PutStatusAsync(int id, bool isActive)
        {
            var tourist =  await _context.tourists.FirstOrDefaultAsync(x => x.id == id);
            tourist.isActive = isActive;
          await  _context.SaveChangesAsync();
        }
        public  async Task<Tourist>UpdateAsync(int id, Tourist newTouirst)
        {
            var touirsts = await _context.tourists.ToListAsync();
            var index = touirsts.FindIndex(x => x.id == id);
            if (index != -1)
            {
                touirsts[index].CountryNameOfBusiness = newTouirst.CountryNameOfBusiness;
                touirsts[index].isActive = newTouirst.isActive;
                await _context.SaveChangesAsync();
                return touirsts[index];
            }
            return null;
        }
    }
}

  



  
    
