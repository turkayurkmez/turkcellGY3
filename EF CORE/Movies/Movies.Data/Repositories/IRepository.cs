using Movies.Entities;

namespace Movies.Data.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task CreateAsync(T entity);
        void Create(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

        Task<IList<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
    }
}
