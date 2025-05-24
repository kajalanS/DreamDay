using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamDay.Migrations
{
    /// <inheritdoc />
    public partial class PricerangeUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fa1f9ef4-f907-4986-b13e-5dcd0b1ca07f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a572c213-71fc-4d1d-9e53-ecfa2272d8ab"), new Guid("4762a68f-4f25-481c-91e6-4df75da3454f") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2bb5e19d-bd07-4b7c-80bf-7448cda47fa7"), new Guid("af11b6cf-317c-46c0-a5ff-c4fcfce1cb80") });

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("17e96843-af99-400e-b740-4c3336c76cc6"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("29f230fc-7efe-40a4-b4db-0c2d0b87638e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("42e06627-9738-4398-91bf-2aadfcf20662"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("457c0aa9-fee6-4502-81ff-c96efc551bd7"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("4e1f626c-f109-477b-9c22-5cc3a5b4e4e1"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("5244c90c-b8db-48e0-b146-6fd0da2269c9"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("565c681c-3db6-4a3b-bbbc-ea8736fa5dda"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("5b083d4f-70d0-4182-abcc-04f47e90dd0e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("6ad4715e-964c-4f4f-be7c-9ef301c83f94"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("7da6f54b-4ba3-4659-a1f2-55fc9afdf357"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("8e2cea40-fc73-4e9c-b61f-fc3488cb71af"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("92a43de7-7c6f-4583-88ee-c9ecfc6f7bc6"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("940943cc-fa56-4936-a0c8-79c7102f2efe"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("978dfdbe-1d66-4708-a1db-3dedec221d1c"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7f7adb2-84be-4763-91b5-7c3b32c1df85"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa401572-adb7-43f2-8e46-e5e7039da5ce"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("b9387807-7fb4-4709-bec5-6792628e67c9"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("b940af13-99b4-4db8-9e4b-1c3358eb7f34"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("bac8315e-fadd-4d39-be0a-00d5dd946311"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("bdc3626f-7780-4a33-b79a-344234187b65"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("c6905b71-ee96-44b3-9a58-3977e8c7084d"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("c6d97e93-7ec5-4f74-aa35-0ef47c96d6e2"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("d4d91247-5de9-4f0f-9e39-c69b47b85f28"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("d5e7f8a3-eb62-45ba-be0e-409a622f7366"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e36071f2-62b1-41dc-b657-f0b6db0db762"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e7533968-f482-4ff9-921e-dcea4b2b3b26"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("ec7377b7-91c7-4e42-a83d-2692effef6c5"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("eecb4776-746c-406c-8f49-f3d69352bf2a"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f29d04b2-2d73-4aa1-b2ad-897f97dddfa2"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f421f65a-6cb9-4d6b-8d51-76da84a39ce6"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4d222ef-9181-47f5-9ab8-1f135aac15e9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2bb5e19d-bd07-4b7c-80bf-7448cda47fa7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a572c213-71fc-4d1d-9e53-ecfa2272d8ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4762a68f-4f25-481c-91e6-4df75da3454f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af11b6cf-317c-46c0-a5ff-c4fcfce1cb80"));

            migrationBuilder.AddColumn<decimal>(
                name: "PriceRange",
                table: "WeddingVendors",
                type: "decimal(65,30)",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceRange",
                table: "Venues",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceRange",
                table: "Vendors",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("87a9b1b4-9189-4f47-b1b1-34491e5bcef8"), null, "Admin", "ADMIN" },
                    { new Guid("c8f693c0-1526-4a85-8fa6-56400391b857"), null, "Vendor", "VENDOR" },
                    { new Guid("efbd35cf-b80d-49bd-839c-562992edfe1a"), null, "Couple", "COUPLE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7af6dd06-07ac-4875-b7bf-bcf1e3db8a8a"), 0, "440a98d4-196c-4188-96b8-3c516ce1390f", "sam@app.com", true, false, null, "SAM@APP.COM", "COUPLE", "AQAAAAIAAYagAAAAEMWMtCTUhljSOmPQSQYwbNawmulfdPUpVwHC2Q6DBrhQW5x29+VwKNwVOo6Xl5UEhg==", null, false, new DateTime(2025, 5, 24, 19, 18, 10, 258, DateTimeKind.Local).AddTicks(9126), "2c5e3000-189c-4e30-9793-b17696cedc7f", 1, false, "Couple" },
                    { new Guid("c1404082-a976-427d-a9c8-ab4422314390"), 0, "353df798-53c4-4bb8-bbdb-5266da766d8f", "admin@app.com", true, false, null, "ADMIN@APP.COM", "ADMIN", "AQAAAAIAAYagAAAAEG3FzSHVz2+LIeJub58I2LoD8YvSfrYRP0iZP97ZCdom/RAd/JoQC4A8fKNskHg0sA==", null, false, new DateTime(2025, 5, 24, 19, 18, 10, 141, DateTimeKind.Local).AddTicks(8108), "f4ae1dba-c8ec-4475-b9a8-b100d07fb946", 1, false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "VendorTypes",
                columns: new[] { "Id", "Category", "VendorTypeName" },
                values: new object[,]
                {
                    { new Guid("034aa76c-d978-4862-ae89-0451d2a9dfe6"), 14, "Chair & Table Rental" },
                    { new Guid("04593b1b-0025-4886-ae1b-e791085d1e13"), 3, "Invitations & Stationery" },
                    { new Guid("0ae11686-a444-4a31-8c1d-8687b35ddf6e"), 1, "Photographer" },
                    { new Guid("0bfc12e1-f919-4713-a6fc-1218b9c64df8"), 12, "Lighting Designer" },
                    { new Guid("1485ac09-540a-4dc5-94ef-e6f51734dabd"), 6, "Caterer" },
                    { new Guid("1bfdf3e9-d3af-4131-bff8-fb1f641c422e"), 4, "Jewelry Boutique" },
                    { new Guid("1c03dc5a-252e-4101-9a16-15bbc15cbd60"), 8, "Floral Arrangements" },
                    { new Guid("306bf9cc-6ac1-4ef6-951c-ceb070a4d3c4"), 6, "Open-Bar Service" },
                    { new Guid("3292f866-7b0c-4de6-a32e-e7624bdb8124"), 9, "Dessert Station" },
                    { new Guid("32a68fec-39ab-4e74-87e3-405b46796d37"), 8, "Event Draping" },
                    { new Guid("3a06f3fe-7ea0-41a2-a4e3-924eb960db57"), 1, "Drone Photographer" },
                    { new Guid("3ddb04d7-33be-4e4b-a906-9ce6f5432064"), 2, "Live Band" },
                    { new Guid("428da178-00f0-4e18-9f86-7899866ab585"), 2, "DJ" },
                    { new Guid("42fd31e5-9163-4004-8097-86ab30ffe81d"), 7, "Limousine Service" },
                    { new Guid("435c9530-31fa-4bef-8754-987a9178c935"), 13, "Event Security" },
                    { new Guid("4493bced-7c61-4321-a601-9a75891a7f6c"), 15, "Beachfront Venue" },
                    { new Guid("5d53f2ec-dc34-4ee4-91ef-654df7ee5795"), 14, "Tent Rental" },
                    { new Guid("63a1f3ab-1c51-405e-b6c2-9925c39c98ad"), 5, "Makeup Artist" },
                    { new Guid("65f3e2dc-e201-4fff-9876-dc6c8c7f2667"), 9, "Wedding Cake Designer" },
                    { new Guid("6e3d496f-faea-48ce-9083-4a1ec60c270c"), 10, "Day-Of Coordinator" },
                    { new Guid("825b63b6-e86d-4f2b-abfd-8b2025147805"), 7, "Vintage Car Rental" },
                    { new Guid("94dfc6fc-1af6-4d84-8012-72ed64deb4ae"), 11, "Fire Dancers" },
                    { new Guid("a012a666-b4f9-4cbc-b7f0-abd2163cf7fc"), 3, "Favors & Gifts" },
                    { new Guid("ad474e49-9090-4508-8792-1215716afa9f"), 5, "Hair Stylist" },
                    { new Guid("b1f59c68-ec92-4a79-baaf-0c271bab8ab7"), 15, "Banquet Hall" },
                    { new Guid("c95e0ad9-cade-40fb-9f42-3d586606231e"), 10, "Full-Service Planner" },
                    { new Guid("e066b176-1b49-4917-a17b-31ec9f6a202f"), 12, "Sound Engineer" },
                    { new Guid("e574a93c-97c6-45b1-a5fe-c07614339f65"), 4, "Bridal Gown Designer" },
                    { new Guid("e8d806ac-ac1e-4215-9843-0b2b8c798928"), 1, "Videographer" },
                    { new Guid("e933fab9-d88b-437e-b9f0-8f4b1c8b37d4"), 13, "First-Aid Staff" },
                    { new Guid("e9d67d93-a2ef-4a2e-9227-dc760b1bffbb"), 11, "String Quartet" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("efbd35cf-b80d-49bd-839c-562992edfe1a"), new Guid("7af6dd06-07ac-4875-b7bf-bcf1e3db8a8a") },
                    { new Guid("87a9b1b4-9189-4f47-b1b1-34491e5bcef8"), new Guid("c1404082-a976-427d-a9c8-ab4422314390") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8f693c0-1526-4a85-8fa6-56400391b857"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("efbd35cf-b80d-49bd-839c-562992edfe1a"), new Guid("7af6dd06-07ac-4875-b7bf-bcf1e3db8a8a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87a9b1b4-9189-4f47-b1b1-34491e5bcef8"), new Guid("c1404082-a976-427d-a9c8-ab4422314390") });

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("034aa76c-d978-4862-ae89-0451d2a9dfe6"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("04593b1b-0025-4886-ae1b-e791085d1e13"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("0ae11686-a444-4a31-8c1d-8687b35ddf6e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("0bfc12e1-f919-4713-a6fc-1218b9c64df8"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("1485ac09-540a-4dc5-94ef-e6f51734dabd"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("1bfdf3e9-d3af-4131-bff8-fb1f641c422e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("1c03dc5a-252e-4101-9a16-15bbc15cbd60"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("306bf9cc-6ac1-4ef6-951c-ceb070a4d3c4"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("3292f866-7b0c-4de6-a32e-e7624bdb8124"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("32a68fec-39ab-4e74-87e3-405b46796d37"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a06f3fe-7ea0-41a2-a4e3-924eb960db57"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("3ddb04d7-33be-4e4b-a906-9ce6f5432064"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("428da178-00f0-4e18-9f86-7899866ab585"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("42fd31e5-9163-4004-8097-86ab30ffe81d"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("435c9530-31fa-4bef-8754-987a9178c935"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("4493bced-7c61-4321-a601-9a75891a7f6c"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("5d53f2ec-dc34-4ee4-91ef-654df7ee5795"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("63a1f3ab-1c51-405e-b6c2-9925c39c98ad"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("65f3e2dc-e201-4fff-9876-dc6c8c7f2667"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("6e3d496f-faea-48ce-9083-4a1ec60c270c"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("825b63b6-e86d-4f2b-abfd-8b2025147805"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("94dfc6fc-1af6-4d84-8012-72ed64deb4ae"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("a012a666-b4f9-4cbc-b7f0-abd2163cf7fc"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("ad474e49-9090-4508-8792-1215716afa9f"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("b1f59c68-ec92-4a79-baaf-0c271bab8ab7"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("c95e0ad9-cade-40fb-9f42-3d586606231e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e066b176-1b49-4917-a17b-31ec9f6a202f"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e574a93c-97c6-45b1-a5fe-c07614339f65"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8d806ac-ac1e-4215-9843-0b2b8c798928"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e933fab9-d88b-437e-b9f0-8f4b1c8b37d4"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e9d67d93-a2ef-4a2e-9227-dc760b1bffbb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("87a9b1b4-9189-4f47-b1b1-34491e5bcef8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efbd35cf-b80d-49bd-839c-562992edfe1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7af6dd06-07ac-4875-b7bf-bcf1e3db8a8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1404082-a976-427d-a9c8-ab4422314390"));

            migrationBuilder.DropColumn(
                name: "PriceRange",
                table: "WeddingVendors");

            migrationBuilder.AlterColumn<string>(
                name: "PriceRange",
                table: "Venues",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PriceRange",
                table: "Vendors",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2bb5e19d-bd07-4b7c-80bf-7448cda47fa7"), null, "Admin", "ADMIN" },
                    { new Guid("a572c213-71fc-4d1d-9e53-ecfa2272d8ab"), null, "Couple", "COUPLE" },
                    { new Guid("fa1f9ef4-f907-4986-b13e-5dcd0b1ca07f"), null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4762a68f-4f25-481c-91e6-4df75da3454f"), 0, "f38fd24e-7eed-4856-a262-4f58a057db97", "sam@app.com", true, false, null, "SAM@APP.COM", "COUPLE", "AQAAAAIAAYagAAAAEDK4RxIz/UY5qgiwKekMV9N/VLgBcFTna8aLvzfWPt1N7LEKPPZOYINKqXf9uYpemA==", null, false, new DateTime(2025, 5, 24, 17, 29, 46, 106, DateTimeKind.Local).AddTicks(8476), "4d7ebde0-49b8-4a8b-ad94-ad83b52632ea", 1, false, "Couple" },
                    { new Guid("af11b6cf-317c-46c0-a5ff-c4fcfce1cb80"), 0, "19aa0fae-7ca3-4ab8-b4dd-2607cc357068", "admin@app.com", true, false, null, "ADMIN@APP.COM", "ADMIN", "AQAAAAIAAYagAAAAEKrM3U9U/CFx9KKG7/0/B9CuktxJQTsn9P6nqX2m2ZevEeI6cHcB5+mARU6M0Yec7w==", null, false, new DateTime(2025, 5, 24, 17, 29, 46, 6, DateTimeKind.Local).AddTicks(4591), "086df827-ca6a-40dc-8296-6f388b5be9e7", 1, false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "VendorTypes",
                columns: new[] { "Id", "Category", "VendorTypeName" },
                values: new object[,]
                {
                    { new Guid("17e96843-af99-400e-b740-4c3336c76cc6"), 9, "Dessert Station" },
                    { new Guid("29f230fc-7efe-40a4-b4db-0c2d0b87638e"), 2, "Live Band" },
                    { new Guid("42e06627-9738-4398-91bf-2aadfcf20662"), 8, "Event Draping" },
                    { new Guid("457c0aa9-fee6-4502-81ff-c96efc551bd7"), 11, "Fire Dancers" },
                    { new Guid("4e1f626c-f109-477b-9c22-5cc3a5b4e4e1"), 6, "Open-Bar Service" },
                    { new Guid("5244c90c-b8db-48e0-b146-6fd0da2269c9"), 11, "String Quartet" },
                    { new Guid("565c681c-3db6-4a3b-bbbc-ea8736fa5dda"), 13, "First-Aid Staff" },
                    { new Guid("5b083d4f-70d0-4182-abcc-04f47e90dd0e"), 1, "Photographer" },
                    { new Guid("6ad4715e-964c-4f4f-be7c-9ef301c83f94"), 12, "Lighting Designer" },
                    { new Guid("7da6f54b-4ba3-4659-a1f2-55fc9afdf357"), 3, "Invitations & Stationery" },
                    { new Guid("8e2cea40-fc73-4e9c-b61f-fc3488cb71af"), 14, "Tent Rental" },
                    { new Guid("92a43de7-7c6f-4583-88ee-c9ecfc6f7bc6"), 7, "Vintage Car Rental" },
                    { new Guid("940943cc-fa56-4936-a0c8-79c7102f2efe"), 6, "Caterer" },
                    { new Guid("978dfdbe-1d66-4708-a1db-3dedec221d1c"), 5, "Hair Stylist" },
                    { new Guid("a7f7adb2-84be-4763-91b5-7c3b32c1df85"), 1, "Drone Photographer" },
                    { new Guid("aa401572-adb7-43f2-8e46-e5e7039da5ce"), 15, "Beachfront Venue" },
                    { new Guid("b9387807-7fb4-4709-bec5-6792628e67c9"), 2, "DJ" },
                    { new Guid("b940af13-99b4-4db8-9e4b-1c3358eb7f34"), 5, "Makeup Artist" },
                    { new Guid("bac8315e-fadd-4d39-be0a-00d5dd946311"), 10, "Full-Service Planner" },
                    { new Guid("bdc3626f-7780-4a33-b79a-344234187b65"), 13, "Event Security" },
                    { new Guid("c6905b71-ee96-44b3-9a58-3977e8c7084d"), 1, "Videographer" },
                    { new Guid("c6d97e93-7ec5-4f74-aa35-0ef47c96d6e2"), 3, "Favors & Gifts" },
                    { new Guid("d4d91247-5de9-4f0f-9e39-c69b47b85f28"), 7, "Limousine Service" },
                    { new Guid("d5e7f8a3-eb62-45ba-be0e-409a622f7366"), 9, "Wedding Cake Designer" },
                    { new Guid("e36071f2-62b1-41dc-b657-f0b6db0db762"), 10, "Day-Of Coordinator" },
                    { new Guid("e7533968-f482-4ff9-921e-dcea4b2b3b26"), 8, "Floral Arrangements" },
                    { new Guid("ec7377b7-91c7-4e42-a83d-2692effef6c5"), 4, "Bridal Gown Designer" },
                    { new Guid("eecb4776-746c-406c-8f49-f3d69352bf2a"), 14, "Chair & Table Rental" },
                    { new Guid("f29d04b2-2d73-4aa1-b2ad-897f97dddfa2"), 12, "Sound Engineer" },
                    { new Guid("f421f65a-6cb9-4d6b-8d51-76da84a39ce6"), 15, "Banquet Hall" },
                    { new Guid("f4d222ef-9181-47f5-9ab8-1f135aac15e9"), 4, "Jewelry Boutique" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a572c213-71fc-4d1d-9e53-ecfa2272d8ab"), new Guid("4762a68f-4f25-481c-91e6-4df75da3454f") },
                    { new Guid("2bb5e19d-bd07-4b7c-80bf-7448cda47fa7"), new Guid("af11b6cf-317c-46c0-a5ff-c4fcfce1cb80") }
                });
        }
    }
}
