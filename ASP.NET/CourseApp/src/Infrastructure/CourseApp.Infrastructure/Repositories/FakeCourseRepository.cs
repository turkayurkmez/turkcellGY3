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
                new() { Id=1, Name="Course X", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=1},
                new() { Id=2, Name="Course Y", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=1},
                new() { Id=3, Name="Course Z", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=1},

                new() { Id=4, Name="Course Q", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=1 },
                new() { Id=5, Name="Course X1", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=2},
                new() { Id=6, Name="Course Y1", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=2},
                new() { Id=7, Name="Course Z1", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=2},
                new() { Id=8, Name="Course Q1", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=2},
                 new() { Id=9, Name="Course X2", Description="Description X", Price=1, Rating=4, TotalHours=20, CategoryId=3},
                new() { Id=10, Name="Course Y2", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=3},
                new() { Id=11, Name="Course Z2", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=3},
                new() { Id=12, Name="Course Q2", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=3},
                new() { Id=13, Name="Course X3", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=3},
                new() { Id=14, Name="Course Y3", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=3},
                new() { Id=15, Name="Course Z3", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=2},
                new() { Id=16, Name="Course Q3", Description="Description X", Price=1, Rating=4, TotalHours=20,CategoryId=1},

            };
        }

        public Task CreateAsync(Course entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Course? Get(int id)
        {
            return _courses.Find(c => c.Id == id);
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

        public IList<Course> GetAllWithPredicate(Expression<Func<Course, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Course?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            return _courses.Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public IEnumerable<Course> GetCoursesByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
