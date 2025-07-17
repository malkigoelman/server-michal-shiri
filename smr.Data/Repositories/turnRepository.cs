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
    public class turnRepository : IturnRepository
    {
        private readonly DataContext _context;

        public turnRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Turn>> GetAllAsync()
        {
            return await _context.turns.ToListAsync();
        }
        public async Task<Turn> GetByIdAsync(int id)
        {
            var turn = await _context.turns.FirstOrDefaultAsync(x => x.id == id);
            await _context.SaveChangesAsync();
            return turn;
        }
        public async Task AddAsync(Turn value)
        {
            await _context.turns.AddAsync(value);
            //  await  _context.SaveChangesAsync();
        }

        public async Task PutAsync(int id, Turn value)
        {
            var turn = await _context.turns.FirstOrDefaultAsync(x => x.id == id);
            turn.id = value.id;
            turn.day = value.day;
            turn.hour = value.hour;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var turn = await _context.turns.FirstOrDefaultAsync(e => e.id == id);
            _context.turns.Remove(turn);
            await _context.SaveChangesAsync();
        }
        public async Task<Turn> UpdateAsync(int id, Turn newTurn)
        {
            var turns = await _context.turns.ToListAsync();
            var index = turns.FindIndex(x => x.id == id);
            if (index != -1)
            {
                turns[index].hour = newTurn.hour;
                turns[index].day = newTurn.day;
                turns[index].TouristId = newTurn.TouristId;
                turns[index].tourist = newTurn.tourist;

                await _context.SaveChangesAsync();
                return turns[index];
            }
            return null;
        }
    }
}


