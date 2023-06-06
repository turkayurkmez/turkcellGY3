using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        Task CreateCourseAsync(CreateNewCourseRequest createNewCourseRequest);
        Task<int> CreateCourseAndReturnIdAsync(CreateNewCourseRequest createNewCourseRequest);

        CourseDisplayResponse GetCourse(int id);

        Task<UpdateCourseRequest> GetCourseForUpdate(int id);

        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
        IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId);

        Task<IEnumerable<CourseDisplayResponse>> SearchByName(string name);

        Task UpdateCourse(UpdateCourseRequest updateCourseRequest);
        Task<bool> CourseIsExists(int courseId);
        Task DeleteAsync(int id);
    }
}
