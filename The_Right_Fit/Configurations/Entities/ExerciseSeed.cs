using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The_Right_Fit.Domain;

namespace The_Right_Fit.Configurations.Entities
{
    public class ExerciseSeed : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(
                new Exercise
                {
                    Id = 1,
                    ExerciseName = "Squat",
                    MuscleGroup = "Legs",
                    EquipmentNeeded = "Barbell",
                    Instructions = "Stand with feet shoulder-width apart, squat down by bending knees and hips, then stand back up.",
                    VideoUrl = "https://www.youtube.com/watch?v=Dy28eq2PjcM",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 2,
                    ExerciseName = "Bench Press",
                    MuscleGroup = "Chest",
                    EquipmentNeeded = "Barbell",
                    Instructions = "Lie on a bench, lower the barbell to your chest, and push it back up.",
                    VideoUrl = "https://www.youtube.com/watch?v=gRVjAtPip0Y",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 3,
                    ExerciseName = "Deadlift",
                    MuscleGroup = "Back",
                    EquipmentNeeded = "Barbell",
                    Instructions = "Lift the barbell from the ground by extending your hips and knees while maintaining a straight back.",
                    VideoUrl = "https://www.youtube.com/watch?v=1ZXobu7JvvE",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 4,
                    ExerciseName = "Push-Up",
                    MuscleGroup = "Chest",
                    EquipmentNeeded = "None",
                    Instructions = "Lower your body towards the ground by bending your elbows, then push back up.",
                    VideoUrl = "https://www.youtube.com/watch?v=_l3ySVKYVJ8",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 5,
                    ExerciseName = "Pull-Up",
                    MuscleGroup = "Back",
                    EquipmentNeeded = "Pull-up Bar",
                    Instructions = "Hang from a bar and pull your chin above the bar, then lower down.",
                    VideoUrl = "https://www.youtube.com/watch?v=eGo4IYlbE5g",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 6,
                    ExerciseName = "Lunges",
                    MuscleGroup = "Legs",
                    EquipmentNeeded = "None",
                    Instructions = "Step forward and lower your body until both knees are bent at 90 degrees, then return to standing.",
                    VideoUrl = "https://www.youtube.com/watch?v=QOVaa9B7nlA",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 7,
                    ExerciseName = "Bicep Curl",
                    MuscleGroup = "Arms",
                    EquipmentNeeded = "Dumbbells",
                    Instructions = "Hold dumbbells and curl them upwards by bending your elbows, then lower down slowly.",
                    VideoUrl = "https://www.youtube.com/watch?v=ykJmrZ5v0Oo",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 8,
                    ExerciseName = "Plank",
                    MuscleGroup = "Core",
                    EquipmentNeeded = "None",
                    Instructions = "Hold a push-up position with your forearms on the ground, keeping your body straight.",
                    VideoUrl = "https://www.youtube.com/watch?v=pSHjTRCQxIw",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 9,
                    ExerciseName = "Shoulder Press",
                    MuscleGroup = "Shoulders",
                    EquipmentNeeded = "Dumbbells",
                    Instructions = "Press the dumbbells upward overhead, then lower them back to shoulder height.",
                    VideoUrl = "https://www.youtube.com/watch?v=B-aVuyhvLHU",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Exercise
                {
                    Id = 10,
                    ExerciseName = "Lat Pulldown",
                    MuscleGroup = "Back",
                    EquipmentNeeded = "Lat Pulldown Machine",
                    Instructions = "Pull the bar down towards your chest while keeping your torso upright, then return slowly.",
                    VideoUrl = "https://www.youtube.com/watch?v=AOpi-p0cJkc",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );

        }
    }
}