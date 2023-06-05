using AutoMapper;
using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Entities;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;

namespace CourseApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CourseDisplayResponse GetCourse(int id)
        {
            var course = _repository.Get(id);
            return _mapper.Map<CourseDisplayResponse>(course);
        }

        public IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses()
        {
            var courses = _repository.GetAll();
            var responses = courses.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId)
        {
            var courses = _repository.GetCoursesByCategory(categoryId);
            var response = courses.ConvertToDisplayResponses(_mapper);
            return response;

        }

        public async Task CreateCourseAsync(CreateNewCourseRequest createNewCourseRequest)
        {
            var course = _mapper.Map<Course>(createNewCourseRequest);
            await _repository.CreateAsync(course);
        }

        public async Task UpdateCourse(UpdateCourseRequest updateCourseRequest)
        {
            var course = _mapper.Map<Course>(updateCourseRequest);
            await _repository.UpdateAsync(course);

        }

        public async Task<bool> CourseIsExists(int courseId)
        {
            return await _repository.IsExistsAsync(courseId);

        }

        public async Task<UpdateCourseRequest> GetCourseForUpdate(int id)
        {
            var course = await _repository.GetAsync(id);
            return _mapper.Map<UpdateCourseRequest>(course);

        }

        public Task<UpdateCourseRequest> GetCourseForUpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
