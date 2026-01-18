using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The_Right_Fit.Domain;

namespace The_Right_Fit.Configurations.Entities
{
    public class WorkoutPlanSeed : IEntityTypeConfiguration<WorkoutPlan>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlan> builder)
        {
            builder.HasData(
                new WorkoutPlan
                {
                    Id = 1,
                    UserId = null,   // Public Plan
                    
                    PlanName = "Beginner Full Body Program",
                    GoalType = "General Fitness",
                    DifficultyLevel = "Beginner",
                    DurationWeeks = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new WorkoutPlan
                {
                    Id = 2,
                    UserId = null,
                    
                    PlanName = "Fat Loss Home Workout Plan",
                    GoalType = "Weight Loss",
                    DifficultyLevel = "Beginner",
                    DurationWeeks = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new WorkoutPlan
                {
                    Id = 3,
                    UserId = null,
                    
                    PlanName = "Muscle Gain Strength Program",
                    GoalType = "Muscle Gain",
                    DifficultyLevel = "Intermediate",
                    DurationWeeks = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new WorkoutPlan
                {
                    Id = 4,
                    UserId = null,
                    
                    PlanName = "Upper / Lower Split Program",
                    GoalType = "Strength Training",
                    DifficultyLevel = "Intermediate",
                    DurationWeeks = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new WorkoutPlan
                {
                    Id = 5,
                    UserId = null,
                    
                    PlanName = "Push Pull Legs (PPL) Program",
                    GoalType = "Muscle Gain",
                    DifficultyLevel = "Advanced",
                    DurationWeeks = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
