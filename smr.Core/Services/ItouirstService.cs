﻿using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Services
{
    public interface ItouirstService
    {
        Task<List<Tourist>> GetListAsync();
        Task<Tourist> GetByIdAsync(int id);
        public Task AddAsync(Tourist value);
        Task<Tourist> PutAsync(int id, Tourist value);
        Task PutStatusAsync(int id, bool isActive);
        Task<Tourist> UpdateAsync(int id, Tourist tourist);
    }
}
