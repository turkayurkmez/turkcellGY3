using System.ComponentModel.DataAnnotations;

namespace CourseApp.DataTransferObjects.Requests
{
    public class CreateNewCourseRequest
    {
        [Required(ErrorMessage = "Kurs adını boş bırakmayınız")]
        [MinLength(3, ErrorMessage = "En az üç harf :)")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Price { get; set; }
        public int? TotalHours { get; set; }
        public string ImageUrl { get; set; } = "https://loremflickr.com/320/240";
        public int? CategoryId { get; set; }
        public byte? Rating { get; set; }
    }
}
