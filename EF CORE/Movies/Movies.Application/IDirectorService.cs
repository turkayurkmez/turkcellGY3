using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;

namespace Movies.Application
{
    public interface IDirectorService
    {
        Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync();
        Task<int> CreateNewDirectorAsync(CreateDirectorRequest request);
        Task<SingleDirectorResponse> GetDirectorAsync(int id);

        Task UpdateDirectorAsync(UpdateDirectorRequest request);

    }
}