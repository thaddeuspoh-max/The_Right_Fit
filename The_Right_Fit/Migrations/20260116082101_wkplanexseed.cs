using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class wkplanexseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84f0bccb-057a-4819-af8c-e3bd1debffa1", "AQAAAAIAAYagAAAAEJhv6lyHMS4SxMT20r9+3EkaJ+NdxWdIMjPXlOXoQFbTg+gVSMVtH0B5G35HTMox2A==", "8df12986-81b4-4d29-98cf-fa0b9b228f1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b72d25ed-b4f6-462a-ad93-4017d9f97703", "AQAAAAIAAYagAAAAENDJhkt2/+N4FuLlRo/7Lx4MyBuxE15pu/8SfCEq5eREqwL8IeDkYc9bkmKoPDSSNg==", "dc8674e6-ba3c-4605-8d44-acacc4e5a2fe" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6738), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6758), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6760), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6763), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6765), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6768), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6770), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6772), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6774), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6776), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6900), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6902), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6904), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6907), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6909), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6911), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6913), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6915), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6917), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6919), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7116), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7119), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7121), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7123), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7125), new DateTime(2026, 1, 16, 16, 21, 0, 206, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.InsertData(
                table: "WorkoutPlanExercise",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DayOfWeek", "ExerciseId", "Reps", "Sets", "UpdatedBy", "WorkoutPlanId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10, 3, null, 1 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 10, 3, null, 1 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, 30, 3, null, 1 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, 12, 3, null, 1 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, 10, 3, null, 1 },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, 12, 3, null, 1 },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, 15, 4, null, 2 },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, 12, 4, null, 2 },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8, 40, 4, null, 2 },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5, 5, null, 3 },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 5, 5, null, 3 },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 5, 5, null, 3 },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, 8, 4, null, 3 },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 8, 4, null, 4 },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, 8, 4, null, 4 },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8, 4, null, 4 },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, 12, 3, null, 4 },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 5, 5, null, 5 },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9, 8, 4, null, 5 },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, 8, 4, null, 5 },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10, 10, 4, null, 5 },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 5, 5, null, 5 },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 5, 4, null, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WorkoutPlanExercise",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa161fc9-569a-40c9-a8b0-33f389bb6d60", "AQAAAAIAAYagAAAAEN9WuyEj7H/gxrlT3KJVf7D4BmT4jMnH4MkaH6qE242UW0U6HChS9OnFEWuSwoAYMg==", "1d21c805-ef2e-4996-b6d7-f424a5c29902" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea633a56-bd48-4977-b0a4-dc4bcfd33bc7", "AQAAAAIAAYagAAAAEOSvf2uAScmpcFkikGDsCCvIv6qkVH1gFOycqIiqxINbfM5WBnZ5C/DJAtQG9YfIbQ==", "1cd89385-660d-4212-a6df-418acebf1068" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(791), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(812), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(814), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(816), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(818), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(820), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(822), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(824), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(826), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(828), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(965), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(967), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(970), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(972), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(974), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(976), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(978), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(982), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(984), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1106), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1108), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1110), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1112), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1114), new DateTime(2026, 1, 16, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1114) });
        }
    }
}
