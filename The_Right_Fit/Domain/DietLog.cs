namespace The_Right_Fit.Domain

{
    public class DietLog : BaseDomainModel
    {
        public int UserId { get; set; }
        public int? FoodItemId { get; set; }

        public DateTime LogDate { get; set; }       // Date of entry
        public string? MealType { get; set; }       // "Breakfast", "Lunch", "Dinner", "Snack"

        public double QuantityServings { get; set; }

        public int TotalCalories { get; set; }

        // Custom food fields (if FoodItemId is null)
        public string? CustomFoodName { get; set; }


    }
}





