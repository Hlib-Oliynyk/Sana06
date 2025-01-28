using Microsoft.AspNetCore.Mvc;
using Sana06.Models;
using System.Diagnostics;

namespace Sana06.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Сторінка про нас.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Сторінка контактів.";
            return View();
        }

    }
}
