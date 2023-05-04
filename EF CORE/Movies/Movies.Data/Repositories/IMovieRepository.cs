using Movies.Entities;

namespace Movies.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IList<Movie>> SearchMoviesByTitle(string title);

    }
}
