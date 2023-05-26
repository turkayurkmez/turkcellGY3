using System.ComponentModel.DataAnnotations;

namespace CourseApp.Entities
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Price { get; set; }
        public int? TotalHours { get; set; }
        public string ImageUrl { get; set; } = "https://loremflickr.com/320/240";
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public byte? Rating { get; set; }
    }
}
