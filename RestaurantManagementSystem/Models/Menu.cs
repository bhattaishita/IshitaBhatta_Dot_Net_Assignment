using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class Menu
    {
        [Key] // Marks foodId as the Primary Key
        public int FoodId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Food name cannot exceed 100 characters.")]
        public string FoodName { get; set; }

        [Required]
        [Range(0.01, 10000, ErrorMessage = "Price must be between 0.01 and 10,000.")]
        public decimal Pricing { get; set; }

        [Range(1, 5, ErrorMessage = "Review rating must be between 1 and 5.")]
        public double Review { get; set; }
    }
}
