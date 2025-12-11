using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The_Right_Fit.Domain;


namespace The_Right_Fit.Configurations.Entities
{
    public class FoodItemsSeed : IEntityTypeConfiguration<FoodItems>
    {
        public void Configure(EntityTypeBuilder<FoodItems> builder)
        {
            builder.HasData(
                new FoodItems
                {
                    Id = 1,
                    Name = "White Rice",
                    ServingSizeDescription = "100g",
                    Calories = 130,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 2,
                    Name = "Chicken Breast",
                    ServingSizeDescription = "100g",
                    Calories = 165,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 3,
                    Name = "Banana",
                    ServingSizeDescription = "1 medium (118g)",
                    Calories = 105,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 4,
                    Name = "Egg",
                    ServingSizeDescription = "1 whole egg",
                    Calories = 72,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 5,
                    Name = "Apple",
                    ServingSizeDescription = "1 medium (182g)",
                    Calories = 95,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 6,
                    Name = "Whole Wheat Bread",
                    ServingSizeDescription = "1 slice",
                    Calories = 70,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 7,
                    Name = "Oatmeal",
                    ServingSizeDescription = "40g (1/2 cup dry)",
                    Calories = 150,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 8,
                    Name = "Milk",
                    ServingSizeDescription = "250ml",
                    Calories = 103,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 9,
                    Name = "Greek Yogurt",
                    ServingSizeDescription = "100g",
                    Calories = 59,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new FoodItems
                {
                    Id = 10,
                    Name = "Salmon",
                    ServingSizeDescription = "100g",
                    Calories = 208,
                    IsCustom = 0,
                    CreatedByUserId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
