using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUpperLowerSplitName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeced980-022f-453d-9568-a37d76205be4", "AQAAAAIAAYagAAAAENxzyK9RmPwADTY/zaq+UmIxnbYO+gLjv4w/KlG8YPFOAczupUmCfj92Env45JTw6g==", "ceac788a-bff1-4c22-9155-ecefbe6468ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0defface-ef22-4f3d-ae89-23205de7b8d3", "AQAAAAIAAYagAAAAEGISXPNjGoBwjdbuZBKbjOeWT6qdUyu4EFoM5Zxfb7ImPRTdEeZJclt9MYD0h4GI4A==", "c89f35a5-9cde-4f87-a4c7-1a1ca24d899d" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3646), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3662), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3664), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3666), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3667), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3669), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3671), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3673), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3675), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3677), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3754), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3757), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3759), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3761), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3762), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3764), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3766), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3768), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3770), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3771), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3845), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3848), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3850), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "PlanName" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3851), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3852), "Upper / Lower Split Program" });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3853), new DateTime(2026, 1, 18, 17, 52, 57, 715, DateTimeKind.Local).AddTicks(3854) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0123b3-0720-4886-957e-2aa321c2de29", "AQAAAAIAAYagAAAAEAwpse+xwjl5mchAl+t1S1Rbno0ajy+2AerZZrFNXMPp88A1p8Bwr6LtoHz0Pg07xg==", "015d8418-1d0a-4bd4-820e-7ffbfbcdeced" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "615656ca-70cc-4679-a801-8214619e0fa1", "AQAAAAIAAYagAAAAEE8MGO1d5YKZYejsxM203LcL305UtKOFdouhtCprW1F7YuzJCfoG28jYGuzAqkwcmA==", "5c15177e-d2fe-4d27-81c1-119b209fb992" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5338), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5357), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5359), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5361), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5363), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5365), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5367), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5369), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5371), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5373), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5514), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5519), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5521), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5523), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5525), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5528), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5530), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5532), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5534), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5661), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5663), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5665), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "PlanName" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5667), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5668), "Upper / Lower Split" });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5669), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5670) });
        }
    }
}
