using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamDay.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77f02a05-46f8-47e3-9de7-8ff0d63d8024"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("975264fb-de9a-4877-9119-352d412c7e2f"), new Guid("41fb3143-5ed5-4629-92ee-47887c1b050a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98887b42-5bce-4330-a750-af946c57a3d8"), new Guid("fb4ab931-92df-41b6-93b6-3796a40bf090") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("975264fb-de9a-4877-9119-352d412c7e2f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("98887b42-5bce-4330-a750-af946c57a3d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41fb3143-5ed5-4629-92ee-47887c1b050a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb4ab931-92df-41b6-93b6-3796a40bf090"));

            migrationBuilder.AddColumn<Guid>(
                name: "WeddingId",
                table: "Vendors",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "WeddingTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    WeddingId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeddingTask_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("50b91ddf-43f6-4d7a-98a2-1e756e2ec09a"), null, "Couple", "COUPLE" },
                    { new Guid("8803160a-2adf-4e95-a8aa-309d3731336f"), null, "Vendor", "VENDOR" },
                    { new Guid("d654ba5d-e938-46d5-9834-868f39748f72"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("30a57a64-ddcb-40a5-ac3f-c10dc12de8c2"), 0, "de1c7a76-b3e4-473c-907b-8bbf1cf60154", "sam@app.com", true, false, null, "SAM@APP.COM", "COUPLE", "AQAAAAIAAYagAAAAEHm4uWIFDnKHjVz7TVWBx5ZVNEHG9hi8FMt7tvvbIjNmnQ8i+qu87hBFus9MGoZ94g==", null, false, new DateTime(2025, 5, 8, 14, 24, 49, 920, DateTimeKind.Local).AddTicks(3868), "e5bec253-6e7a-4899-9566-f8ce0842575a", 1, false, "Couple" },
                    { new Guid("d32b3463-04de-4327-9c0e-a1d57d53e13e"), 0, "65a7982a-f2d0-4df5-9ecd-0eda6159ae1f", "admin@app.com", true, false, null, "ADMIN@APP.COM", "ADMIN", "AQAAAAIAAYagAAAAEMvy/aedmTdvwVfBxeU2ZYeE2AZJOJ6ychmmqhGgh9ztDzHoBuWgIWNP5BkNbYxS4g==", null, false, new DateTime(2025, 5, 8, 14, 24, 49, 812, DateTimeKind.Local).AddTicks(212), "773e89e9-cd5b-4938-bd01-b484fbb8f3dd", 1, false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("50b91ddf-43f6-4d7a-98a2-1e756e2ec09a"), new Guid("30a57a64-ddcb-40a5-ac3f-c10dc12de8c2") },
                    { new Guid("d654ba5d-e938-46d5-9834-868f39748f72"), new Guid("d32b3463-04de-4327-9c0e-a1d57d53e13e") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_WeddingId",
                table: "Vendors",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTask_WeddingId",
                table: "WeddingTask",
                column: "WeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Weddings_WeddingId",
                table: "Vendors",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Weddings_WeddingId",
                table: "Vendors");

            migrationBuilder.DropTable(
                name: "WeddingTask");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_WeddingId",
                table: "Vendors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8803160a-2adf-4e95-a8aa-309d3731336f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("50b91ddf-43f6-4d7a-98a2-1e756e2ec09a"), new Guid("30a57a64-ddcb-40a5-ac3f-c10dc12de8c2") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d654ba5d-e938-46d5-9834-868f39748f72"), new Guid("d32b3463-04de-4327-9c0e-a1d57d53e13e") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("50b91ddf-43f6-4d7a-98a2-1e756e2ec09a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d654ba5d-e938-46d5-9834-868f39748f72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30a57a64-ddcb-40a5-ac3f-c10dc12de8c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d32b3463-04de-4327-9c0e-a1d57d53e13e"));

            migrationBuilder.DropColumn(
                name: "WeddingId",
                table: "Vendors");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("77f02a05-46f8-47e3-9de7-8ff0d63d8024"), null, "Vendor", "VENDOR" },
                    { new Guid("975264fb-de9a-4877-9119-352d412c7e2f"), null, "Admin", "ADMIN" },
                    { new Guid("98887b42-5bce-4330-a750-af946c57a3d8"), null, "Couple", "COUPLE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("41fb3143-5ed5-4629-92ee-47887c1b050a"), 0, "059f565a-3598-4760-b060-872427d758ef", "admin@app.com", true, false, null, "ADMIN@APP.COM", "ADMIN", "AQAAAAIAAYagAAAAED7rbpYdwXyTPxQIby75+X5C6m64hhyeA4jTjQBKOHrRTvMflzfAHdhzTHyTO2f5lA==", null, false, new DateTime(2025, 4, 5, 11, 38, 32, 71, DateTimeKind.Local).AddTicks(7332), "dc2f58b0-b71d-4fed-b19c-ab16490c60b6", 1, false, "Admin" },
                    { new Guid("fb4ab931-92df-41b6-93b6-3796a40bf090"), 0, "4e2c4763-4cf3-493a-8b59-89f9f34b0e37", "sam@app.com", true, false, null, "SAM@APP.COM", "COUPLE", "AQAAAAIAAYagAAAAEOGsut9+TuPV9hHHk0nMO+/XGtk1FomCtffeAND3BUMi+tgbDzkW8BCMEKgNFXbORw==", null, false, new DateTime(2025, 4, 5, 11, 38, 32, 147, DateTimeKind.Local).AddTicks(8407), "92bed828-f1d7-456e-b583-bf8cca0edcec", 1, false, "Couple" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("975264fb-de9a-4877-9119-352d412c7e2f"), new Guid("41fb3143-5ed5-4629-92ee-47887c1b050a") },
                    { new Guid("98887b42-5bce-4330-a750-af946c57a3d8"), new Guid("fb4ab931-92df-41b6-93b6-3796a40bf090") }
                });
        }
    }
}
