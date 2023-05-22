using CourseApp.Entities;
using System.Linq.Expressions;

namespace CourseApp.Infrastructure.Repositories
{
    public class FakeCourseRepository : ICourseRepository
    {

        private List<Course> _courses;
        public FakeCourseRepository()
        {
            _courses = new()
            {
                new() { Id=1, Name="Course X", Description="Description X", Price=1, Rating=4, TotalHours=20},
                new() { Id=2, Name="Course Y", Description="Description X", Price=1, Rating=4, TotalHours=20},
                new() { Id=3, Name="Course Z", Description="Description X", Price=1, Rating=4, TotalHours=20},

                new() { Id=4, Name="Course Q", Description="Description X", Price=1, Rating=4, TotalHours=20},

            };
        }
        public Course? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Course?> GetAll()
        {
            return _courses;
        }

        public Task<IList<Course?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Course> GetAllWithPredicate(Expression<Predicate<Course>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Course?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
