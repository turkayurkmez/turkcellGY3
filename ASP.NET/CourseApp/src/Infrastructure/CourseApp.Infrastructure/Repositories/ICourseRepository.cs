using CourseApp.Entities;

namespace CourseApp.Infrastructure.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        public IEnumerable<Course> GetCoursesByCategory(int categoryId);
        public IEnumerable<Course> GetCoursesByName(string name);

    }
}
