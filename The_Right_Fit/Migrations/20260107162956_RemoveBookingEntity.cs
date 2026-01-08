using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBookingEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3758edcb-c768-4716-8e6d-deaa596e01fb", "AQAAAAIAAYagAAAAEItOwKI2o8YIsrg30Zt1yaXAj2k9mkggRZQimpKbYsd81Czw/XIYePfdY8zihQazsw==", "d77be2af-49bc-4243-97c4-47ee51b10156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee111111-2222-3333-4444-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c23b06-5a0b-46bb-9700-49b1b7ab429b", "AQAAAAIAAYagAAAAEJAJzIkAD5KOvn4+tZNr4hQOSAmavy0SIVdzHWfdvUE9uOMWRrNXjtrgkl2uapsmPw==", "95d81d76-6e4b-48e2-a9e3-aadfa67880e0" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8026), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8050), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8053), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8055), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8058), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8060), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8062), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8064), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8066), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8068), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8258), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8261), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8263), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8265), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8268), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8270), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8272), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8274), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8276), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8278), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8405), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8408), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8411), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8413), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8415), new DateTime(2026, 1, 8, 0, 29, 55, 461, DateTimeKind.Local).AddTicks(8416) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e95e461c-54e0-4ad5-80e7-01f7c54713be", "AQAAAAIAAYagAAAAEDPOFojSrMRCRVBiGs7iWZA0P3/+poSbn3QURq2oB7OSV94qOTmVLaPA3WcXXPeOQA==", "1707b38c-a903-452d-bcd1-1ceb3bec155f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee111111-2222-3333-4444-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b33f6a48-96a2-43e5-846d-eb7ce3cf936d", "AQAAAAIAAYagAAAAEDJA5CGYA4bLEVHouaOgYDZ1WY0VjFCRf9Bmircxnlw/vmld77TTL31muX/M2be61g==", "3a598664-aecd-43c2-a283-0910103b6bd7" });

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
        }
    }
}
