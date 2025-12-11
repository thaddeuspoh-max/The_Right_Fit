using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "EquipmentNeeded", "ExerciseName", "Instructions", "MuscleGroup", "UpdatedBy", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(267), "Barbell", "Squat", "Stand with feet shoulder-width apart, squat down by bending knees and hips, then stand back up.", "Legs", "System", "https://www.youtube.com/watch?v=Dy28eq2PjcM" },
                    { 2, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(273), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(274), "Barbell", "Bench Press", "Lie on a bench, lower the barbell to your chest, and push it back up.", "Chest", "System", "https://www.youtube.com/watch?v=gRVjAtPip0Y" },
                    { 3, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(276), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(276), "Barbell", "Deadlift", "Lift the barbell from the ground by extending your hips and knees while maintaining a straight back.", "Back", "System", "https://www.youtube.com/watch?v=1ZXobu7JvvE" },
                    { 4, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(278), "None", "Push-Up", "Lower your body towards the ground by bending your elbows, then push back up.", "Chest", "System", "https://www.youtube.com/watch?v=_l3ySVKYVJ8" },
                    { 5, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(280), "Pull-up Bar", "Pull-Up", "Hang from a bar and pull your chin above the bar, then lower down.", "Back", "System", "https://www.youtube.com/watch?v=eGo4IYlbE5g" },
                    { 6, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(281), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(282), "None", "Lunges", "Step forward and lower your body until both knees are bent at 90 degrees, then return to standing.", "Legs", "System", "https://www.youtube.com/watch?v=QOVaa9B7nlA" },
                    { 7, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(283), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(284), "Dumbbells", "Bicep Curl", "Hold dumbbells and curl them upwards by bending your elbows, then lower down slowly.", "Arms", "System", "https://www.youtube.com/watch?v=ykJmrZ5v0Oo" },
                    { 8, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(285), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(286), "None", "Plank", "Hold a push-up position with your forearms on the ground, keeping your body straight.", "Core", "System", "https://www.youtube.com/watch?v=pSHjTRCQxIw" },
                    { 9, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(287), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(287), "Dumbbells", "Shoulder Press", "Press the dumbbells upward overhead, then lower them back to shoulder height.", "Shoulders", "System", "https://www.youtube.com/watch?v=B-aVuyhvLHU" },
                    { 10, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(289), "Lat Pulldown Machine", "Lat Pulldown", "Pull the bar down towards your chest while keeping your torso upright, then return slowly.", "Back", "System", "https://www.youtube.com/watch?v=AOpi-p0cJkc" }
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "Calories", "CreatedBy", "CreatedByUserId", "DateCreated", "DateUpdated", "IsCustom", "Name", "ServingSizeDescription", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 130, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(477), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(478), 0, "White Rice", "100g", "System" },
                    { 2, 165, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(481), 0, "Chicken Breast", "100g", "System" },
                    { 3, 105, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(483), 0, "Banana", "1 medium (118g)", "System" },
                    { 4, 72, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(485), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(485), 0, "Egg", "1 whole egg", "System" },
                    { 5, 95, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(487), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(487), 0, "Apple", "1 medium (182g)", "System" },
                    { 6, 70, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(489), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(489), 0, "Whole Wheat Bread", "1 slice", "System" },
                    { 7, 150, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(491), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(491), 0, "Oatmeal", "40g (1/2 cup dry)", "System" },
                    { 8, 103, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(493), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(493), 0, "Milk", "250ml", "System" },
                    { 9, 59, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(495), 0, "Greek Yogurt", "100g", "System" },
                    { 10, 208, "System", null, new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(496), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(497), 0, "Salmon", "100g", "System" }
                });

            migrationBuilder.InsertData(
                table: "WorkoutPlan",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DifficultyLevel", "DurationWeeks", "GoalType", "PlanName", "TrainerId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(603), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(604), "Beginner", 6, "General Fitness", "Beginner Full Body Program", null, "System", null },
                    { 2, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(605), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(606), "Beginner", 4, "Weight Loss", "Fat Loss Home Workout Plan", null, "System", null },
                    { 3, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(608), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(608), "Intermediate", 8, "Muscle Gain", "Muscle Gain Strength Program", null, "System", null },
                    { 4, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(610), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(610), "Intermediate", 6, "Strength Training", "Upper / Lower Split", null, "System", null },
                    { 5, "System", new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(612), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(612), "Advanced", 8, "Muscle Gain", "Push Pull Legs (PPL) Program", null, "System", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
