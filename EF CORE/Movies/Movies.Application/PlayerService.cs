using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;

namespace Movies.Application
{
    public class PlayerService
    {
        private readonly IPlayerRepository repository;

        public PlayerService(IPlayerRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<PlayerListResponse>> GetPlayerLists()
        {
            var players = await repository.GetAllAsync();
            return players.Select(p => new PlayerListResponse
            {
                Id = p.Id,
                Name = p.Name,
                Info = p.Info,
                LastName = p.LastName
            });
        }

        public async Task<int> CreateNewPlayer(CreateNewPlayerRequest request)
        {
            Player player = new()
            {
                Info = request.Info,
                LastName = request.LastName,
                Name = request.Name,

            };

            await repository.CreateAsync(player);
            return player.Id;
        }

        public async Task UpdatePlayer(UpdatePlayerRequest request)
        {
            Player player = new()
            {
                Info = request.Info,
                LastName = request.LastName,
                Name = request.Name,
                Id = request.Id

            };
            await repository.UpdateAsync(player);
        }


    }
}
