namespace Movies.Entities
{
    public class MoviesPlayer
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public string Role { get; set; }

    }
}
