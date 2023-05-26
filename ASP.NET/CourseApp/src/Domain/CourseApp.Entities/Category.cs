using System.ComponentModel.DataAnnotations;

namespace CourseApp.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
