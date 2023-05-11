namespace Movies.Application.DTOs.Requests
{
    public class UpdatePlayerRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Info { get; set; }
    }
}
