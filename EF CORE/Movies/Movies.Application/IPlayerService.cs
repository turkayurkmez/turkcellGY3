using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;

namespace Movies.Application
{
    public interface IPlayerService
    {
        Task<int> CreateNewPlayer(CreateNewPlayerRequest request);
        Task<IEnumerable<PlayerListResponse>> GetPlayerLists();
        Task UpdatePlayer(UpdatePlayerRequest request);
    }
}