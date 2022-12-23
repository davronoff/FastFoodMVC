using FastFoodMVC.Models;

namespace FastFoodMVC.Interface
{
    public interface IFoodInterface
    {
        List<Food> GetAllFoods(); // Hamma foodlarni oladigan method
        Food GetById(int foodId); // Bir dona food olish
        Food AddFood(Food food); // Food qo'shoish
        Food UpdateFood(Food food); // Foodni ozgartirish 
        void DeleteFood(int id); // Keraksiz foodni idisi orqali ochirish
    }
}
