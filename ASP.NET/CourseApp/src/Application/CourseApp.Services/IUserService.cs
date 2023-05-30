using CourseApp.Entities;

namespace CourseApp.Services
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}
