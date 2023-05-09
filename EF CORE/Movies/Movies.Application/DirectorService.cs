using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;

namespace Movies.Application
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        public Task<int> CreateNewDirector(string name, string lastName, string info)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateNewDirectorAsync(CreateDirectorRequest request)
        {
            var director = new Director
            {
                Info = request.Info,
                LastName = request.LastName,
                Name = request.Name,
            };

            await directorRepository.CreateAsync(director);
            return director.Id;
        }

        public async Task<SingleDirectorResponse> GetDirectorAsync(int id)
        {
            var director = await directorRepository.GetByIdAsync(id);
            return new SingleDirectorResponse
            {
                Info = director.Info,
                LastName = director.LastName,
                Name = director.Name,
            };

        }

        public async Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync()
        {
            var directors = await directorRepository.GetAllAsync();
            var responses = directors.Select(d => new DirectorListResponse
            {
                Id = d.Id,
                Info = d.Info,
                LastName = d.LastName,
                Name = d.Name
            });

            return responses;
        }

        public async Task UpdateDirectorAsync(UpdateDirectorRequest request)
        {
            var director = new Director
            {
                Id = request.Id,
                Info = request.Info,
                LastName = request.LastName,
                Name = request.Name
            };
            await directorRepository.UpdateAsync(director);
        }
    }
}
