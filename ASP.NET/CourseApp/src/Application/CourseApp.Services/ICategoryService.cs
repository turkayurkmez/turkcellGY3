using CourseApp.DataTransferObjects.Responses;

namespace CourseApp.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDisplayResponse> GetCategoriesForList();
    }
}