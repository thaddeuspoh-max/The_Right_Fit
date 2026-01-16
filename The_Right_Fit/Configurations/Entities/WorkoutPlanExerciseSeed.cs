using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The_Right_Fit.Domain;

namespace The_Right_Fit.Configurations.Entities
{
    public class WorkoutPlanExerciseSeed : IEntityTypeConfiguration<WorkoutPlanExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlanExercise> builder)
        {
            builder.HasData(

                // =====================================================
                // PLAN 1 – Beginner Full Body Program (3 days)
                // =====================================================

                // Day 1
                new WorkoutPlanExercise { Id = 1, WorkoutPlanId = 1, ExerciseId = 1, DayOfWeek = 1, Sets = 3, Reps = 10 }, // Squat
                new WorkoutPlanExercise { Id = 2, WorkoutPlanId = 1, ExerciseId = 2, DayOfWeek = 1, Sets = 3, Reps = 10 }, // Bench
                new WorkoutPlanExercise { Id = 3, WorkoutPlanId = 1, ExerciseId = 8, DayOfWeek = 1, Sets = 3, Reps = 30 }, // Plank

                // Day 3
                new WorkoutPlanExercise { Id = 4, WorkoutPlanId = 1, ExerciseId = 4, DayOfWeek = 3, Sets = 3, Reps = 12 }, // Push-up
                new WorkoutPlanExercise { Id = 5, WorkoutPlanId = 1, ExerciseId = 6, DayOfWeek = 3, Sets = 3, Reps = 10 }, // Lunges
                new WorkoutPlanExercise { Id = 6, WorkoutPlanId = 1, ExerciseId = 7, DayOfWeek = 3, Sets = 3, Reps = 12 }, // Curl

                // =====================================================
                // PLAN 2 – Fat Loss Home Workout
                // =====================================================

                new WorkoutPlanExercise { Id = 7, WorkoutPlanId = 2, ExerciseId = 4, DayOfWeek = 2, Sets = 4, Reps = 15 }, // Push-up
                new WorkoutPlanExercise { Id = 8, WorkoutPlanId = 2, ExerciseId = 6, DayOfWeek = 2, Sets = 4, Reps = 12 }, // Lunges
                new WorkoutPlanExercise { Id = 9, WorkoutPlanId = 2, ExerciseId = 8, DayOfWeek = 2, Sets = 4, Reps = 40 }, // Plank

                // =====================================================
                // PLAN 3 – Muscle Gain Strength Program
                // =====================================================

                new WorkoutPlanExercise { Id = 10, WorkoutPlanId = 3, ExerciseId = 1, DayOfWeek = 1, Sets = 5, Reps = 5 }, // Squat
                new WorkoutPlanExercise { Id = 11, WorkoutPlanId = 3, ExerciseId = 3, DayOfWeek = 1, Sets = 5, Reps = 5 }, // Deadlift
                new WorkoutPlanExercise { Id = 12, WorkoutPlanId = 3, ExerciseId = 2, DayOfWeek = 3, Sets = 5, Reps = 5 }, // Bench
                new WorkoutPlanExercise { Id = 13, WorkoutPlanId = 3, ExerciseId = 9, DayOfWeek = 3, Sets = 4, Reps = 8 }, // Shoulder

                // =====================================================
                // PLAN 4 – Upper / Lower Split
                // =====================================================

                // Upper
                new WorkoutPlanExercise { Id = 14, WorkoutPlanId = 4, ExerciseId = 2, DayOfWeek = 1, Sets = 4, Reps = 8 }, // Bench
                new WorkoutPlanExercise { Id = 15, WorkoutPlanId = 4, ExerciseId = 5, DayOfWeek = 1, Sets = 4, Reps = 8 }, // Pull-up

                // Lower
                new WorkoutPlanExercise { Id = 16, WorkoutPlanId = 4, ExerciseId = 1, DayOfWeek = 3, Sets = 4, Reps = 8 }, // Squat
                new WorkoutPlanExercise { Id = 17, WorkoutPlanId = 4, ExerciseId = 6, DayOfWeek = 3, Sets = 3, Reps = 12 }, // Lunges

                // =====================================================
                // PLAN 5 – Push Pull Legs (Advanced)
                // =====================================================

                // Push
                new WorkoutPlanExercise { Id = 18, WorkoutPlanId = 5, ExerciseId = 2, DayOfWeek = 1, Sets = 5, Reps = 5 },
                new WorkoutPlanExercise { Id = 19, WorkoutPlanId = 5, ExerciseId = 9, DayOfWeek = 1, Sets = 4, Reps = 8 },

                // Pull
                new WorkoutPlanExercise { Id = 20, WorkoutPlanId = 5, ExerciseId = 5, DayOfWeek = 3, Sets = 4, Reps = 8 },
                new WorkoutPlanExercise { Id = 21, WorkoutPlanId = 5, ExerciseId = 10, DayOfWeek = 3, Sets = 4, Reps = 10 },

                // Legs
                new WorkoutPlanExercise { Id = 22, WorkoutPlanId = 5, ExerciseId = 1, DayOfWeek = 5, Sets = 5, Reps = 5 },
                new WorkoutPlanExercise { Id = 23, WorkoutPlanId = 5, ExerciseId = 3, DayOfWeek = 5, Sets = 4, Reps = 5 }
            );
        }
    }
}
