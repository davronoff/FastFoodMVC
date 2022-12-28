using System.ComponentModel.DataAnnotations;

namespace FastFoodMVC.ViewModels
{
    public class AddFoodViewModel
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public IFormFile? Image { get; set; }

    }
}
