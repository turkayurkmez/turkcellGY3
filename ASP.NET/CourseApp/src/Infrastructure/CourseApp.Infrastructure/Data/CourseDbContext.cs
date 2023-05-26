using CourseApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Infrastructure.Data
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {
        }
    }
}
