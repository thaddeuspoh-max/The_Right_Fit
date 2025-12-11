using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Right_Fit.Configurations.Entities;
using The_Right_Fit.Domain;

namespace The_Right_Fit.Data
{
    public class The_Right_FitContext : DbContext
    {
        public The_Right_FitContext (DbContextOptions<The_Right_FitContext> options)
            : base(options)
        {
        }

        public DbSet<The_Right_Fit.Domain.Booking> Booking { get; set; } = default!;
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
            builder.ApplyConfiguration(new ExerciseSeed());
            builder.ApplyConfiguration(new FoodItemsSeed());
            builder.ApplyConfiguration(new WorkoutPlanSeed());
        }
    }
}
