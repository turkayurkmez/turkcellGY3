using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            //if (!id.HasValue)
            //{
            //    return NotFound();
            //},
            ViewBag.Name = "Türkay";
            ViewBag.Month = DateTime.Now.Month;
            ViewBag.Year = DateTime.Now.Year;
            ViewBag.Items = new List<string> { "A", "B", "C" };
            return View();
        }

        public IActionResult Privacy()
        {
            var privacy = new Privacy() { Info = "Bu uygulama çerezleri kullanır", Header = "Gizlilik" };

            return View(privacy);

        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserRegisterModel values)
        {
            var items = values;

            return View();
        }



    }
}
