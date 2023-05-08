namespace Movies.Application.DTOs.Requests
{
    public class UpdateMovieRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? PublishDate { get; set; }
        public string? Poster { get; set; }
        public int? Duration { get; set; }
        public double? Rating { get; set; }
        public int? DirectorId { get; set; }
    }
}
