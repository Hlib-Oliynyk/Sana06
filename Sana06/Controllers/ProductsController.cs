using Microsoft.AspNetCore.Mvc;

namespace Sana06.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Деталі продукту.";
            return View();
        }

    }
}
