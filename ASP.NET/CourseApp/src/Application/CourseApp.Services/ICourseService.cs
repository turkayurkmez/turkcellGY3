using CourseApp.DataTransferObjects.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
    }
}
