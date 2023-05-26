using CourseApp.Entities;
using System.Linq.Expressions;

namespace CourseApp.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T? Get(int id);
        Task<T?> GetAsync(int id);

        IList<T?> GetAll();
        Task<IList<T?>> GetAllAsync();

        IList<T> GetAllWithPredicate(Expression<Func<T, bool>> predicate);

        Task CreateAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);



    }
}
