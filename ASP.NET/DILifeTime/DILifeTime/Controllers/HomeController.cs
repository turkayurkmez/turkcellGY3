using DILifeTime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DILifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuid _singleton;
        private readonly IScopedGuid _scoped;
        private readonly ITransientGuid _transient;
        private readonly GuidService guidService;
        public HomeController(ILogger<HomeController> logger, ISingletonGuid singleton,
                                                              IScopedGuid scoped,
                                                              ITransientGuid transient,
                                                              GuidService guidService
                                                              )
        {
            _logger = logger;
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
            this.guidService = guidService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singleton.Guid.ToString();
            ViewBag.Scoped = _scoped.Guid.ToString();
            ViewBag.Transient = _transient.Guid.ToString();

            ViewBag.SingletonService = guidService.Singleton.Guid.ToString();
            ViewBag.ScopedService = guidService.Scoped.Guid.ToString();
            ViewBag.TransientService = guidService.Transient.Guid.ToString();

            return View();
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