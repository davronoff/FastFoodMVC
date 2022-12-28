using FastFoodMVC.Interface;
using FastFoodMVC.Models;
using FastFoodMVC.Service;
using FastFoodMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFoodInterface _foodInterface;
        private IImageControllerInterface _imageController;

        public AdminController(IFoodInterface foodInterface,
                                IImageControllerInterface imageController)
        {
            _foodInterface = foodInterface;
            _imageController = imageController;
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
        public IActionResult Add(AddFoodViewModel viewModel)
        {
            Food food = new Food()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Image = _imageController.SaveImage(viewModel.Image)
            };
            _foodInterface.AddFood(food);
            return RedirectToAction("index");
        }
    }
}
