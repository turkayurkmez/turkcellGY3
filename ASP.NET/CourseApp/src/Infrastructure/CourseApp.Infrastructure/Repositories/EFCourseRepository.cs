using CourseApp.Entities;
using CourseApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseApp.Infrastructure.Repositories
{
    public class EFCourseRepository : ICourseRepository
    {
        private readonly CourseDbContext courseDbContext;

        public EFCourseRepository(CourseDbContext courseDbContext)
        {
            this.courseDbContext = courseDbContext;
        }

        public async Task CreateAsync(Course entity)
        {
            await courseDbContext.Courses.AddAsync(entity);
            await courseDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await courseDbContext.Courses.FindAsync(id);
            courseDbContext.Courses.Remove(deleting);
            await courseDbContext.SaveChangesAsync();
        }

        public Course? Get(int id)
        {
            return courseDbContext.Courses.SingleOrDefault(x => x.Id == id);
        }

        public IList<Course?> GetAll()
        {
            return courseDbContext.Courses.AsNoTracking().ToList();
        }

        public async Task<IList<Course?>> GetAllAsync()
        {
            return await courseDbContext.Courses.AsNoTracking().ToListAsync();
        }

        public IList<Course> GetAllWithPredicate(Expression<Func<Course, bool>> predicate)
        {
            return courseDbContext.Courses.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Course?> GetAsync(int id)
        {
            return await courseDbContext.Courses.AsNoTracking().FirstAsync(p => p.Id == id);
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            return courseDbContext.Courses.AsNoTracking().Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public IEnumerable<Course> GetCoursesByName(string name)
        {
            return courseDbContext.Courses.AsNoTracking().Where(c => c.Name.Contains(name)).AsEnumerable();

        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await courseDbContext.Courses.AnyAsync(c => c.Id == id);

        }

        public async Task UpdateAsync(Course entity)
        {
            courseDbContext.Courses.Update(entity);
            await courseDbContext.SaveChangesAsync();
        }
    }
}
