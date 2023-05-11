using Movies.Entities;

namespace Movies.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IList<Movie>> SearchMoviesByTitle(string title);
        Task AddPlayerToMovie(int movieId, List<int> selectedPlayers);
    }
}
