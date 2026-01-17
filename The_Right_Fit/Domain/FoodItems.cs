namespace The_Right_Fit.Domain
{
    public class FoodItems : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? ServingSizeDescription { get; set; }

        public int Calories { get; set; }

        public int IsCustom { get; set; }
        public string? CreatedByUserId { get; set; }


    }
}