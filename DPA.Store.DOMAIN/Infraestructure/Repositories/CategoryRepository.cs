using DPA.Store.DOMAIN.Core.Entities;
using DPA.Store.DOMAIN.Core.Interfaces;
using DPA.Store.DOMAIN.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DPA.Store.DOMAIN.Infraestructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _dbContext;

        public CategoryRepository(StoreDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetAll() {
            return await _dbContext.Category.ToListAsync();
        }

        public async Task<Category> Get(int idCategory) {
            return await _dbContext.Category.FindAsync(idCategory);
        }

        public async Task<bool> Put(Category category) {
            return true;
        }
    }
}
