namespace CourseApp.DataTransferObjects.Responses
{
    public class CourseDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; } = "https://loremflickr.com/320/240";

        public byte? Rating { get; set; }

    }
}
