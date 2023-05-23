using CourseApp.Entities;
using System.Linq.Expressions;

namespace CourseApp.Infrastructure.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public FakeCategoryRepository()
        {
            _categories = new() {
                new() { Id=1, Name="Language" },
                new() { Id=2, Name="Programming" },
                new() { Id=3, Name="Philosophy" },
            };
        }
        public Category? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category?> GetAll()
        {
            return _categories;
        }

        public Task<IList<Category?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAllWithPredicate(Expression<Predicate<Category>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
