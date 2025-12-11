using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Right_Fit.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(273), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(276), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(281), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(283), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(285), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(287), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(477), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(485), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(487), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(489), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(491), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(493), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(496), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(603), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(605), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(608), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(610), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "WorkoutPlan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(612), new DateTime(2025, 12, 11, 21, 10, 24, 374, DateTimeKind.Local).AddTicks(612) });
        }
    }
}
