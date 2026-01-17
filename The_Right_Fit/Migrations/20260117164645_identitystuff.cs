using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class identitystuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerIdentityUserId",
                table: "WorkoutLog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerIdentityUserId",
                table: "DietLog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abdf0ebb-1247-4bf3-bf88-3b8fb7b49b07", "AQAAAAIAAYagAAAAEJFuZahxxcJh941Migc3naghnuQ6CEr9lf1TAxcupEHG6NWIprc6IBBqJCY9jPC1nA==", "eb55c67f-ee63-4e33-b146-de13d9540f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99999999-8888-7777-6666-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3317ec4-c6b6-4bec-ac2e-60a7e017a3d2", "AQAAAAIAAYagAAAAEBw+pDE0JpdI/CKNzSg3yx1GMw/cuW/MhLpcPaA9JNguG3NsiNiADuGYgV4rwNAZBg==", "d6b1be1b-642a-4450-a15f-00703d8928ee" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5398), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5418), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5422), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5425), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5428), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5431), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5437), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5440), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5443), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5617), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5621), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5625), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5832), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5836), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5839), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5842), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5845), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5848), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5851), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6117), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6122), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6126), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6129), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6131), new DateTime(2026, 1, 18, 0, 46, 43, 885, DateTimeKind.Local).AddTicks(6132) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerIdentityUserId",
                table: "WorkoutLog");

            migrationBuilder.DropColumn(
                name: "OwnerIdentityUserId",
                table: "DietLog");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5077), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5079), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5081), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5083), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5086), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5088), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5089), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5091), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5093), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5095), new DateTime(2026, 1, 17, 21, 34, 49, 895, DateTimeKind.Local).AddTicks(5096) });

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
    }
}
