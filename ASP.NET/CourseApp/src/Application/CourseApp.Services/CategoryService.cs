using AutoMapper;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;

namespace CourseApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryService(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<CategoryDisplayResponse> GetCategoriesForList()
        {
            var items = _repository.GetAll();
            var responses = items.ConvertToDto(_mapper);
            return responses;
        }
    }
}
