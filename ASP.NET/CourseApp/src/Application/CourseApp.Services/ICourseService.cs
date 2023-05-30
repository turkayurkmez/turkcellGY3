using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        Task CreateCourseAsync(CreateNewCourseRequest createNewCourseRequest);
        CourseDisplayResponse GetCourse(int id);
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();

        IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId);
    }
}
