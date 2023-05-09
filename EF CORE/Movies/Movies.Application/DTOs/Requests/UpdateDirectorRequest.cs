namespace Movies.Application.DTOs.Requests
{
    public class UpdateDirectorRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }
    }
}
