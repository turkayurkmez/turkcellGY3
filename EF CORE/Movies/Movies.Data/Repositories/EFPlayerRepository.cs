using Microsoft.EntityFrameworkCore;
using Movies.Data.Data;
using Movies.Entities;

namespace Movies.Data.Repositories
{
    public class EFPlayerRepository : IPlayerRepository
    {

        private readonly MoviesDbContext moviesDbContext;

        public EFPlayerRepository(MoviesDbContext moviesDbContext)
        {
            this.moviesDbContext = moviesDbContext;
        }

        public void Create(Player entity)
        {
            //Hem senkron hem de asenkron metotların olması bir tercihtir.
        }

        public async Task CreateAsync(Player entity)
        {
            await moviesDbContext.Players.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await moviesDbContext.Players.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            moviesDbContext.Players.Remove(existing);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task<IList<Player>> GetAllAsync()
        {
            return await moviesDbContext.Players.ToListAsync();
        }

        public async Task<Player?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Players.FindAsync(id);
        }

        public async Task UpdateAsync(Player entity)
        {
            moviesDbContext.Players.Update(entity);
            await moviesDbContext.SaveChangesAsync();

        }
    }
}
