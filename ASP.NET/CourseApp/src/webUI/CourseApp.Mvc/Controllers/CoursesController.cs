using CourseApp.DataTransferObjects.Requests;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseApp.Mvc.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ICategoryService categoryService;

        public CoursesController(ICourseService courseService, ICategoryService categoryService)
        {
            this.courseService = courseService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var courses = courseService.GetCourseDisplayResponses();
            return View(courses);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = getCategoriesForSelectList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewCourseRequest request)
        {
            if (ModelState.IsValid)
            {
                await courseService.CreateCourseAsync(request);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = getCategoriesForSelectList();
            return View();

        }

        private IEnumerable<SelectListItem> getCategoriesForSelectList()
        {
            var categories = categoryService.GetCategoriesForList().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            // categories.Insert(0, new SelectListItem { Text = "Seçiniz", Value = string.Empty });
            return categories;
        }
    }
}
