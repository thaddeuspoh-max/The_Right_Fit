using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using The_Right_Fit.Configurations.Entities;
using The_Right_Fit.Data;

namespace The_Right_Fit.Data
{
    public class The_Right_FitContext(DbContextOptions<The_Right_FitContext> options) : IdentityDbContext<The_Right_FitUser>(options)
    {
        
        public DbSet<The_Right_Fit.Domain.DietLog> DietLog { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.Exercise> Exercise { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.FoodItems> FoodItems { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.UserProfile> UserProfile { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.WorkoutLog> WorkoutLog { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.WorkoutLogExercise> WorkoutLogExercise { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.WorkoutPlan> WorkoutPlan { get; set; } = default!;
        public DbSet<The_Right_Fit.Domain.WorkoutPlanExercise> WorkoutPlanExercise { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeed());        // Roles: Admin, User, Trainer
            builder.ApplyConfiguration(new UserSeed());        // Admin + Trainer users
            builder.ApplyConfiguration(new UserRoleSeed());    // Assign roles to users

            // =============================
            // APP ENTITY SEEDS
            // =============================

            builder.ApplyConfiguration(new ExerciseSeed());
            builder.ApplyConfiguration(new FoodItemsSeed());
            builder.ApplyConfiguration(new WorkoutPlanSeed());
        }
    }
}
