using CourseApp.Entities;
using CourseApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseApp.Infrastructure.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {

        private readonly CourseDbContext courseDbContext;

        public EFCategoryRepository(CourseDbContext courseDbContext)
        {
            this.courseDbContext = courseDbContext;
        }

        public async Task CreateAsync(Category entity)
        {
            await courseDbContext.Categories.AddAsync(entity);
            await courseDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingCategory = await courseDbContext.Categories.FindAsync(id);
            courseDbContext.Categories.Remove(deletingCategory);
            await courseDbContext.SaveChangesAsync();

        }

        public Category? Get(int id)
        {
            return courseDbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        public IList<Category?> GetAll()
        {
            return courseDbContext.Categories.ToList();
        }

        public async Task<IList<Category?>> GetAllAsync()
        {
            return await courseDbContext.Categories.ToListAsync();
        }

        public IList<Category> GetAllWithPredicate(Expression<Func<Category, bool>> predicate)
        {
            return courseDbContext.Categories.Where(predicate).ToList();
        }

        public async Task<Category?> GetAsync(int id)
        {
            return await courseDbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<bool> IsExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Category entity)
        {
            courseDbContext.Categories.Update(entity);
            await courseDbContext.SaveChangesAsync();
        }
    }
}
