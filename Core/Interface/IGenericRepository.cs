using Core.Entity;

namespace Core.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetIdAsync(int id);
    }
}