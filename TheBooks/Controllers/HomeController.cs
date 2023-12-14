using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheBooks.Models;

namespace TheBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult EditBook()
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
