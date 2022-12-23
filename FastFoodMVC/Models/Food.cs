namespace FastFoodMVC.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Image { get; set; } = string.Empty;

    }
}
