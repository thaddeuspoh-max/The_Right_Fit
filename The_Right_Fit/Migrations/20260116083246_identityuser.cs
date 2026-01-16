using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class identityuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerIdentityUserId",
                table: "WorkoutPlan",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4875), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4878), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4880), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4882), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4883), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4886), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4888), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4890), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4891), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4893), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "OwnerIdentityUserId" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5029), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5029), null });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "OwnerIdentityUserId" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5031), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5032), null });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "OwnerIdentityUserId" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5033), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5034), null });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "OwnerIdentityUserId" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5035), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5036), null });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "OwnerIdentityUserId" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 1, 16, 16, 32, 46, 86, DateTimeKind.Local).AddTicks(5038), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerIdentityUserId",
                table: "WorkoutPlan");

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
        }
    }
}
