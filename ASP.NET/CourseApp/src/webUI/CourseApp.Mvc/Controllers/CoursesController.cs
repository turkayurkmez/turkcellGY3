using CourseApp.DataTransferObjects.Requests;
using CourseApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseApp.Mvc.Controllers
{
    [Authorize(Roles = "Admin,Editor")]
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ICategoryService categoryService;

        public CoursesController(ICourseService courseService, ICategoryService categoryService)
        {
            this.courseService = courseService;
            this.categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var courses = courseService.GetCourseDisplayResponses();
            return View(courses);
        }
        [HttpGet]
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
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = getCategoriesForSelectList();
            var course = await courseService.GetCourseForUpdate(id);

            return View(course);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, UpdateCourseRequest updateCourseRequest)
        {
            if (await courseService.CourseIsExists(id))
            {
                if (ModelState.IsValid)
                {
                    await courseService.UpdateCourse(updateCourseRequest);
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Categories = getCategoriesForSelectList();
                return View();
            }
            return NotFound();
        }


        private IEnumerable<SelectListItem> getCategoriesForSelectList()
        {
            var categories = categoryService.GetCategoriesForList().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            // categories.Insert(0, new SelectListItem { Text = "Seçiniz", Value = string.Empty });
            return categories;
        }
    }
}
