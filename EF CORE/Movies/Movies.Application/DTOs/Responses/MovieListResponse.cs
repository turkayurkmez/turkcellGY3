namespace Movies.Application.DTOs.Responses
{
    public class MovieListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? PublishDate { get; set; }
        public string? Poster { get; set; }
        public int? Duration { get; set; }
        public double? Rating { get; set; }
        public string? DirectoryName { get; set; }
        public string? Players { get; set; }



    }
}
