using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class usertoworkoutplan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "WorkoutPlan",
                newName: "OwnerUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a6927b-5d2b-4195-9a20-009e55ef05b7", "AQAAAAIAAYagAAAAEJqN8lhyOFMU5W1NAxZiNYJkCXcuNmvKxcRQv1PbdNrYX7TlOWwfpL3ElNPm8fhVmg==", "89621fdc-e316-4ae7-93c3-2d74c2c403fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee111111-2222-3333-4444-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b448b0e-6fba-4504-ab66-e4ae1abc6b70", "AQAAAAIAAYagAAAAEMC/Klf75K6mWgLY+PGyP94gsOjpLHA81o2eSJ7HkIzDsjiwLBAp+eLJhhWsi4sZJw==", "86564c70-2937-4591-b861-bf431fd64ee6" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7522), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7572), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7576), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7581), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7586), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7590), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7815), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7820), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7824), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7828), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8897), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8902), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8906), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8910), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8988), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8993), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8997), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9002), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9007), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9419), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9426), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9431), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9435), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9440), new DateTime(2026, 1, 15, 9, 36, 17, 619, DateTimeKind.Local).AddTicks(9440) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "WorkoutPlan",
                newName: "TrainerId");

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
    }
}
