using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamDay.Migrations
{
    /// <inheritdoc />
    public partial class PriceRangToVendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "PriceRange",
                table: "Vendors",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PriceRange",
                table: "Vendors");

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
        }
    }
}
