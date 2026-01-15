using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeightCm = table.Column<double>(type: "float", nullable: true),
                    WeightKg = table.Column<double>(type: "float", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GoalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodItemId = table.Column<int>(type: "int", nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityServings = table.Column<double>(type: "float", nullable: false),
                    TotalCalories = table.Column<int>(type: "int", nullable: false),
                    CustomFoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MuscleGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentNeeded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServingSizeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    IsCustom = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: true),
                    WorkoutDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutLogExercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutLogId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    ActualSets = table.Column<int>(type: "int", nullable: false),
                    ActualReps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutLogExercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerUserId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationWeeks = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlanExercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlanExercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "GoalType", "HeightCm", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "WeightKg" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d6b508b8-6140-4e97-bc94-e82591960366", null, "admin@therightfit.com", true, "Admin", null, null, null, "User", false, null, "ADMIN@THERIGHTFIT.COM", "ADMIN@THERIGHTFIT.COM", "AQAAAAIAAYagAAAAEOaXzc5fZVKJ0oNjTziLZG0y+RSVUxWigE2LF3bK2lzwlAXMVgGGIyMJO9KepQNJNQ==", null, false, "4bd88830-d959-4600-9572-f45a3e42f321", false, "admin@therightfit.com", null },
                    { "99999999-8888-7777-6666-555555555555", 0, "0c4607a9-802d-4243-80e9-f0c5995d4a6f", null, "user@therightfit.com", true, "Jane", null, null, null, "User", false, null, "USER@THERIGHTFIT.COM", "USER@THERIGHTFIT.COM", "AQAAAAIAAYagAAAAEBREZ+NUHQjdYnj+BVZ09odtj5+bXygwTlKsg/NhbsnbUzxtDVIPD/bPU+Q4Z85tpA==", null, false, "2929a6bd-c67f-4644-8531-87210d827553", false, "user@therightfit.com", null }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "EquipmentNeeded", "ExerciseName", "Instructions", "MuscleGroup", "UpdatedBy", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7521), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7538), "Barbell", "Squat", "Stand with feet shoulder-width apart, squat down by bending knees and hips, then stand back up.", "Legs", "System", "https://www.youtube.com/watch?v=Dy28eq2PjcM" },
                    { 2, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7541), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7541), "Barbell", "Bench Press", "Lie on a bench, lower the barbell to your chest, and push it back up.", "Chest", "System", "https://www.youtube.com/watch?v=gRVjAtPip0Y" },
                    { 3, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7543), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7543), "Barbell", "Deadlift", "Lift the barbell from the ground by extending your hips and knees while maintaining a straight back.", "Back", "System", "https://www.youtube.com/watch?v=1ZXobu7JvvE" },
                    { 4, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7545), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7545), "None", "Push-Up", "Lower your body towards the ground by bending your elbows, then push back up.", "Chest", "System", "https://www.youtube.com/watch?v=_l3ySVKYVJ8" },
                    { 5, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7547), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7547), "Pull-up Bar", "Pull-Up", "Hang from a bar and pull your chin above the bar, then lower down.", "Back", "System", "https://www.youtube.com/watch?v=eGo4IYlbE5g" },
                    { 6, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7549), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7549), "None", "Lunges", "Step forward and lower your body until both knees are bent at 90 degrees, then return to standing.", "Legs", "System", "https://www.youtube.com/watch?v=QOVaa9B7nlA" },
                    { 7, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7551), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7551), "Dumbbells", "Bicep Curl", "Hold dumbbells and curl them upwards by bending your elbows, then lower down slowly.", "Arms", "System", "https://www.youtube.com/watch?v=ykJmrZ5v0Oo" },
                    { 8, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7553), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7553), "None", "Plank", "Hold a push-up position with your forearms on the ground, keeping your body straight.", "Core", "System", "https://www.youtube.com/watch?v=pSHjTRCQxIw" },
                    { 9, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7555), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7555), "Dumbbells", "Shoulder Press", "Press the dumbbells upward overhead, then lower them back to shoulder height.", "Shoulders", "System", "https://www.youtube.com/watch?v=B-aVuyhvLHU" },
                    { 10, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7556), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7557), "Lat Pulldown Machine", "Lat Pulldown", "Pull the bar down towards your chest while keeping your torso upright, then return slowly.", "Back", "System", "https://www.youtube.com/watch?v=AOpi-p0cJkc" }
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "Calories", "CreatedBy", "CreatedByUserId", "DateCreated", "DateUpdated", "IsCustom", "Name", "ServingSizeDescription", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 130, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7690), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7691), 0, "White Rice", "100g", "System" },
                    { 2, 165, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7693), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7693), 0, "Chicken Breast", "100g", "System" },
                    { 3, 105, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7695), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7695), 0, "Banana", "1 medium (118g)", "System" },
                    { 4, 72, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7697), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7697), 0, "Egg", "1 whole egg", "System" },
                    { 5, 95, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7698), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7699), 0, "Apple", "1 medium (182g)", "System" },
                    { 6, 70, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7700), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7701), 0, "Whole Wheat Bread", "1 slice", "System" },
                    { 7, 150, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7702), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7703), 0, "Oatmeal", "40g (1/2 cup dry)", "System" },
                    { 8, 103, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7704), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7705), 0, "Milk", "250ml", "System" },
                    { 9, 59, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7706), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7706), 0, "Greek Yogurt", "100g", "System" },
                    { 10, 208, "System", null, new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7708), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7708), 0, "Salmon", "100g", "System" }
                });

            migrationBuilder.InsertData(
                table: "WorkoutPlan",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DifficultyLevel", "DurationWeeks", "GoalType", "OwnerUserId", "PlanName", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7831), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7831), "Beginner", 6, "General Fitness", null, "Beginner Full Body Program", "System", null },
                    { 2, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7833), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7833), "Beginner", 4, "Weight Loss", null, "Fat Loss Home Workout Plan", "System", null },
                    { 3, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7835), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7835), "Intermediate", 8, "Muscle Gain", null, "Muscle Gain Strength Program", "System", null },
                    { 4, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7837), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7837), "Intermediate", 6, "Strength Training", null, "Upper / Lower Split", "System", null },
                    { 5, "System", new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7839), new DateTime(2026, 1, 16, 1, 8, 19, 25, DateTimeKind.Local).AddTicks(7839), "Advanced", 8, "Muscle Gain", null, "Push Pull Legs (PPL) Program", "System", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "99999999-8888-7777-6666-555555555555" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DietLog");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "FoodItems");

            migrationBuilder.DropTable(
                name: "WorkoutLog");

            migrationBuilder.DropTable(
                name: "WorkoutLogExercise");

            migrationBuilder.DropTable(
                name: "WorkoutPlan");

            migrationBuilder.DropTable(
                name: "WorkoutPlanExercise");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
