using joaoVito_mvc_RM86293.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace joaoVito_mvc_RM86293.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult contatos()
        {
            return View();
        }
        public IActionResult home()
        {
            return View();
        }
        public IActionResult login()
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
