using CourseApp.Entities;

namespace CourseApp.Infrastructure.Data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(CourseDbContext dbContext)
        {
            seedCategoryIfNoExists(dbContext);
            seedCourseIfNotExists(dbContext);

        }

        private static void seedCategoryIfNoExists(CourseDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<Category>() {
                 new() { Name="Yabancı Dil Kursları", Description="..." },
                 new() { Name="Kişisel Gelişim Kursları", Description="..." },
                 new() { Name="Yazılım Geliştirme Eğitimleri", Description="..." },


                };

                dbContext.Categories.AddRange(categories);
                dbContext.SaveChanges();
            }

        }

        private static void seedCourseIfNotExists(CourseDbContext dbContext)
        {
            if (!dbContext.Courses.Any())
            {
                var courses = new List<Course>()
                {
                    new(){ CategoryId=1, ImageUrl="https://loremflickr.com/320/240", Name="İspanyolca", Price=10.75M, Rating=5, TotalHours=120  },
                    new(){ CategoryId=2, ImageUrl="https://loremflickr.com/320/240", Name="Stres ile mücadele", Price=50M, Rating=5, TotalHours=100  },
                    new(){ CategoryId=3, ImageUrl="https://loremflickr.com/320/240", Name="İleri C#", Price=10.75M, Rating=5, TotalHours=120  }
                };
                dbContext.Courses.AddRange(courses);
                dbContext.SaveChanges();
            }
        }
    }
}
