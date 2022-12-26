using Microsoft.AspNetCore.Mvc;

namespace FastFoodMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
