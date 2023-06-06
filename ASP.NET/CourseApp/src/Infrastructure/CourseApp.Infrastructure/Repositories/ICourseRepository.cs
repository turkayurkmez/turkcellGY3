using CourseApp.Entities;

namespace CourseApp.Infrastructure.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        public IEnumerable<Course> GetCoursesByCategory(int categoryId);

        public Task<IEnumerable<Course>> GetCoursesByCategoryAsync(int categoryId);

        public Task<IEnumerable<Course>> GetCoursesByName(string name);

    }
}
