using Movies.Entities;

namespace Movies.Data.Repositories
{
    public class SingletonRepository : IRepository<SingletonEntity>
    {
        public Task CreateAsync(SingletonEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<SingletonEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SingletonEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SingletonEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
