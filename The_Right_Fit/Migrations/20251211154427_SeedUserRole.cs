using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518cc", null, "Trainer", "TRAINER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e95e461c-54e0-4ad5-80e7-01f7c54713be", "admin@therightfit.com", true, "Admin", "User", false, null, "ADMIN@THERIGHTFIT.COM", "ADMIN@THERIGHTFIT.COM", "AQAAAAIAAYagAAAAEDPOFojSrMRCRVBiGs7iWZA0P3/+poSbn3QURq2oB7OSV94qOTmVLaPA3WcXXPeOQA==", null, false, "1707b38c-a903-452d-bcd1-1ceb3bec155f", false, "admin@therightfit.com" },
                    { "ee111111-2222-3333-4444-555555555555", 0, "b33f6a48-96a2-43e5-846d-eb7ce3cf936d", "trainer@therightfit.com", true, "John", "Trainer", false, null, "TRAINER@THERIGHTFIT.COM", "TRAINER@THERIGHTFIT.COM", "AQAAAAIAAYagAAAAEDJA5CGYA4bLEVHouaOgYDZ1WY0VjFCRf9Bmircxnlw/vmld77TTL31muX/M2be61g==", null, false, "3a598664-aecd-43c2-a283-0910103b6bd7", false, "trainer@therightfit.com" }
                });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5947), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5965), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5969), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5971), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5976), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5978), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6056), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6241), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6244), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6246), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6248), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6250), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6252), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6253), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6255), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6257), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6389), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6392), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6394), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6396), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6398), new DateTime(2025, 12, 11, 23, 44, 26, 971, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518cc", "ee111111-2222-3333-4444-555555555555" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518cc", "ee111111-2222-3333-4444-555555555555" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee111111-2222-3333-4444-555555555555");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2965), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2985), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2987), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2989), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2991), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2993), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2995), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2997), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3211), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3213), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3215), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3217), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3219), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3221), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3224), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3228), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3385), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3390), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3392), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3394), new DateTime(2025, 12, 11, 23, 27, 24, 677, DateTimeKind.Local).AddTicks(3394) });
        }
    }
}
