namespace Movies.Entities
{
    public class Director : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Info { get; set; }

        public ICollection<Movie> Movies { get; set; }



    }
}
