using FastFoodMVC.DataLayer;
using FastFoodMVC.Interface;
using FastFoodMVC.Models;

namespace FastFoodMVC.Repo
{
    public class FoodRepo : IFoodInterface
    {
        private readonly DataContext _datacontext;
        public FoodRepo(DataContext dataContext)
        {
            _datacontext = dataContext;
        }
        public Food AddFood(Food food)
        {
            _datacontext.Foods.Add(food);
            _datacontext.SaveChanges();
            return food;
        }

        public void DeleteFood(int id)
        {
            var food = _datacontext.Foods.FirstOrDefault(f => f.Id == id);
            _datacontext.Foods.Remove(food);
            _datacontext.SaveChanges();
        }

        public List<Food> GetAllFoods()
        {
            var allFood = _datacontext.Foods.ToList();
            return allFood;
        }

        public Food GetById(int foodId)
        {
            var food = _datacontext.Foods.FirstOrDefault(f => f.Id == foodId);
            return food;
        }

        public Food UpdateFood(Food food)
        {
            _datacontext.Foods.Update(food);
            _datacontext.SaveChanges();
            return food;
        }
    }
}
