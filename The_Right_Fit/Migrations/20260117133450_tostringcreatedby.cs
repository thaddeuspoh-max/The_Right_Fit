using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class tostringcreatedby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a734c4c-dcac-46a6-9f8c-2a1d83f89d62", "AQAAAAIAAYagAAAAEEx8leGgnMIecYzqEdOJk0U5CmiOSITMlb/FIqauSeggT+w58Sd7dz8zxeaVFn/rUg==", "8ff529f9-d458-4081-9992-8064d4cd5c6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b725fd1d-b0de-4951-b59c-2bc15dfa5d61", "AQAAAAIAAYagAAAAEPTLpv/T1BGlgrLwQ1wDh0+iX/BZWSjVCr+anNLHAgm4aQuddRpOJ0H9y9mFifQ9xQ==", "80fbb821-e04f-457a-bd61-e248e8f9f563" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4916), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4938), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4941), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4943), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4945), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4946), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4948), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4950), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4952), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4954), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5077), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5079), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5081), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5083), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5086), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5088), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5089), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5091), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5093), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5095), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5207), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5209), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5212), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5214), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5216), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5216) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserId",
                table: "FoodItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dac85fc-12e2-4d7e-a438-ca472a2a8b12", "AQAAAAIAAYagAAAAEG7Etf5B+vBIGhSvQUe9rbXUpWC68/pFbgOghLR/oqatgiQUIi4iHrIBE3jkz5FQMw==", "ed92cfc2-9724-46da-8c15-c8bd5d7813d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c4cb0a1-fd98-4882-ac40-4ec7cc46c9e1", "AQAAAAIAAYagAAAAEAux+4sZlziwKga96bLL1NSO8NLtFiBfRwhoFRU3jhlltYN6N1zZBX0xgb1KYZRFyA==", "6d529a5e-4994-408e-a644-00b0e0f4d7c2" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4705), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4724), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4726), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4728), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4730), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4732), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4734), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4736), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4738), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4740), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4875), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4878), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4880), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4882), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4883), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4886), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4888), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4890), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4891), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedByUserId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4893), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5029), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5031), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5033), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5035), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5038) });
        }
    }
}
