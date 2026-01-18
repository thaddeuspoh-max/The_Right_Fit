using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class Activeplan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivePlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerIdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivePlan", x => x.Id);
                });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5667), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5669), new DateTime(2026, 1, 18, 12, 52, 22, 200, DateTimeKind.Local).AddTicks(5670) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivePlan");

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
    }
}
