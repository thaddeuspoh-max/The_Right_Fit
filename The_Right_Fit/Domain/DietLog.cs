using System.ComponentModel.DataAnnotations;

namespace The_Right_Fit.Domain
{
    public class DietLog : BaseDomainModel
    {
        
        public string OwnerIdentityUserId { get; set; } = string.Empty;

        // you can keep this for now (but don't use it for security/filtering)
        public int UserId { get; set; }

        public int? FoodItemId { get; set; }
        public DateTime LogDate { get; set; }
        public string? MealType { get; set; }

        public double QuantityServings { get; set; }
        public int TotalCalories { get; set; }

        public string? CustomFoodName { get; set; }
    }
}



