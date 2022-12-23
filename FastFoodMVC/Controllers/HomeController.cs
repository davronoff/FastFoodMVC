using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FastFoodMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

    }
}