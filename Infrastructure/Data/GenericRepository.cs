using Core.Entity;
using Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var generic = await _context.Set<T>().ToListAsync();
            return generic;
        }

        public async Task<T> GetIdAsync(int id)
        {
            var single = await _context.Set<T>().FindAsync(id);
            return single;
        }
    }
}