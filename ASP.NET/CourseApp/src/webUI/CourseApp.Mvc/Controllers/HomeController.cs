using CourseApp.Mvc.Models;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseService _courseService;
        public HomeController(ILogger<HomeController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        public IActionResult Index(int pageNo = 1)
        {

            var courses = _courseService.GetCourseDisplayResponses();

            /*
             * 1. Sayfa:
             * 0 eleman atla 8 eleman al
             * 
             * 2. Sayfa:
             * 8 eleman atla 8 eleman al
             * 
             * 3. sayfa:
             * 16 eleman atla 8 eleman al
             */
            /*Kursların toplam sayfa sayısı için hangi bilgiler gerekli?
             * 
             * 1. Sayfada kaç kurs olacak? ,
             * 2. Toplam kaç kurs var? 
             */
            var coursePerPage = 8;
            var courseCount = courses.Count();
            var totalPage = Math.Ceiling((decimal)courseCount / coursePerPage);

            var pagingInfo = new PagingInfo
            {
                CurrentPage = pageNo,
                ItemsPerPage = 8,
                TotalItems = courseCount
            };



            var paginatedCourses = courses.OrderBy(c => c.Id)
                                          .Skip((pageNo - 1) * coursePerPage)
                                          .Take(coursePerPage)
                                          .ToList();

            var model = new PaginationCourseViewModel
            {
                Courses = paginatedCourses,
                PagingInfo = pagingInfo
            };



            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}