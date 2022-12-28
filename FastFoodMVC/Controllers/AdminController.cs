using FastFoodMVC.Interface;
using FastFoodMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFoodInterface _foodInterface;

        public AdminController(IFoodInterface foodInterface)
        {
            _foodInterface = foodInterface;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var allFood = _foodInterface.GetAllFoods();
            return View(allFood);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Food food)
        {
            _foodInterface.AddFood(food);
            return RedirectToAction("index");
        }
    }
}
