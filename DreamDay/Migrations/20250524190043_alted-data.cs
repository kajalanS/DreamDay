using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamDay.Migrations
{
    /// <inheritdoc />
    public partial class alteddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4e644711-1d37-410c-af65-e7fa722d64a7"), null, "Admin", "ADMIN" },
                    { new Guid("8b3ce346-67bb-4312-a57e-92b4301d13ae"), null, "Vendor", "VENDOR" },
                    { new Guid("c127da08-1222-4d2b-afb2-a3ec31e66afd"), null, "Couple", "COUPLE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("28eb636a-8544-4370-9c54-062710899555"), 0, "7b49680a-04b1-416c-9394-34a8271e8413", "admin@app.com", true, false, null, "ADMIN@APP.COM", "ADMIN", "AQAAAAIAAYagAAAAELpXnytIaga6ZoSJzu3WHE0wEKiY61KcyRG4XvOIDF5VH9+3GTYNIUJsxxFtXYRvfA==", null, false, new DateTime(2025, 5, 25, 0, 30, 42, 582, DateTimeKind.Local).AddTicks(9220), "92b7e235-3fd8-442b-8fe7-adf069b8dc60", 1, false, "Admin" },
                    { new Guid("6be76b5e-a23d-44f9-b700-7a93873cf84e"), 0, "f3c1928e-320e-4293-a974-8e8a788048d1", "sam@app.com", true, false, null, "SAM@APP.COM", "COUPLE", "AQAAAAIAAYagAAAAEKl+nIG5+jjEhph7D90v1xjFMW1Tux1tY7dBUkDFE2zqbHs9VMvEpZqmd2bECEIX/g==", null, false, new DateTime(2025, 5, 25, 0, 30, 42, 660, DateTimeKind.Local).AddTicks(7366), "4bfad8ee-aba3-4b44-a139-414ef139e31e", 1, false, "Couple" }
                });

            migrationBuilder.InsertData(
                table: "VendorTypes",
                columns: new[] { "Id", "Category", "VendorTypeName" },
                values: new object[,]
                {
                    { new Guid("00cdac55-8f43-4a56-b57d-0ab04ef06248"), 10, "Full-Service Planner" },
                    { new Guid("06489567-80ef-4f29-952a-8be8a4506f22"), 5, "Hair Stylist" },
                    { new Guid("13f011d8-5bb9-4920-83ce-e34a51ff24c4"), 1, "Drone Photographer" },
                    { new Guid("2afce0c6-51c9-4a4f-965d-7ccf4b282577"), 9, "Dessert Station" },
                    { new Guid("2e853e0b-bd61-4483-a59c-a3d1e25ee66f"), 13, "Event Security" },
                    { new Guid("37ba4f38-d384-4249-a1e1-8f75bd6596d0"), 10, "Day-Of Coordinator" },
                    { new Guid("46a54468-b090-41c4-863f-94b3d42e41dd"), 13, "First-Aid Staff" },
                    { new Guid("4c96e866-70d9-49ea-b447-31de79b8af55"), 12, "Sound Engineer" },
                    { new Guid("500b0e2c-47a6-4d1e-8223-134568e862b9"), 9, "Wedding Cake Designer" },
                    { new Guid("6085313c-f1cc-4548-923f-dc3b4d84c7ae"), 2, "Live Band" },
                    { new Guid("63aec35a-6370-44ca-840a-41eee329c726"), 1, "Videographer" },
                    { new Guid("66a45e6c-1ace-4c55-8cf0-b79ab7e8f6f5"), 8, "Floral Arrangements" },
                    { new Guid("6ed383d4-a894-4145-ac05-b467034443b5"), 11, "String Quartet" },
                    { new Guid("73ea3df9-5bcf-4a23-a60a-b8c645ce976a"), 14, "Chair & Table Rental" },
                    { new Guid("74cca048-a681-4954-8b62-689a856cfa07"), 11, "Fire Dancers" },
                    { new Guid("7bfdbd7a-b214-45be-aaeb-ce65921f5262"), 12, "Lighting Designer" },
                    { new Guid("8bfe0139-17e9-42bb-b7ec-3c4f3a20b1ec"), 3, "Invitations & Stationery" },
                    { new Guid("8c3e9ba7-bd92-47d5-93fc-2a1daecaa2e3"), 5, "Makeup Artist" },
                    { new Guid("900239f7-c5e3-4e6a-84d5-7cb536aed4da"), 1, "Photographer" },
                    { new Guid("90536c78-f9f9-45e2-95bf-0289b87f5c71"), 4, "Bridal Gown Designer" },
                    { new Guid("ab3a4c1c-e519-41e5-988d-0ab00a103855"), 6, "Caterer" },
                    { new Guid("b9e51fce-5d2e-46c7-ae2c-65d71236c01e"), 8, "Event Draping" },
                    { new Guid("c0495cc3-5354-4cbd-9251-ef10ecdf321a"), 3, "Favors & Gifts" },
                    { new Guid("dbcc76a3-2043-49f9-b6a8-240fcea97eea"), 7, "Vintage Car Rental" },
                    { new Guid("e3dc2a2f-1a36-413f-9406-c1b63cd51d2d"), 4, "Jewelry Boutique" },
                    { new Guid("ee3302d3-3dbf-4b2c-9c9e-45e7bb5f1c11"), 14, "Tent Rental" },
                    { new Guid("f04ba061-6419-4301-9167-3cf8efddab59"), 15, "Banquet Hall" },
                    { new Guid("f2572e34-1cf2-46c1-9be5-c0ad230258d5"), 7, "Limousine Service" },
                    { new Guid("f60b80b2-f14c-432d-a8da-317dfc1aed5b"), 15, "Beachfront Venue" },
                    { new Guid("f9a0b33f-534b-4add-9735-d1eccb0f387f"), 6, "Open-Bar Service" },
                    { new Guid("fef30d07-4f6d-4632-83f1-2c3ca4654047"), 2, "DJ" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4e644711-1d37-410c-af65-e7fa722d64a7"), new Guid("28eb636a-8544-4370-9c54-062710899555") },
                    { new Guid("c127da08-1222-4d2b-afb2-a3ec31e66afd"), new Guid("6be76b5e-a23d-44f9-b700-7a93873cf84e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8b3ce346-67bb-4312-a57e-92b4301d13ae"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4e644711-1d37-410c-af65-e7fa722d64a7"), new Guid("28eb636a-8544-4370-9c54-062710899555") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c127da08-1222-4d2b-afb2-a3ec31e66afd"), new Guid("6be76b5e-a23d-44f9-b700-7a93873cf84e") });

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("00cdac55-8f43-4a56-b57d-0ab04ef06248"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("06489567-80ef-4f29-952a-8be8a4506f22"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("13f011d8-5bb9-4920-83ce-e34a51ff24c4"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("2afce0c6-51c9-4a4f-965d-7ccf4b282577"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("2e853e0b-bd61-4483-a59c-a3d1e25ee66f"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("37ba4f38-d384-4249-a1e1-8f75bd6596d0"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("46a54468-b090-41c4-863f-94b3d42e41dd"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("4c96e866-70d9-49ea-b447-31de79b8af55"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("500b0e2c-47a6-4d1e-8223-134568e862b9"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("6085313c-f1cc-4548-923f-dc3b4d84c7ae"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("63aec35a-6370-44ca-840a-41eee329c726"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("66a45e6c-1ace-4c55-8cf0-b79ab7e8f6f5"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("6ed383d4-a894-4145-ac05-b467034443b5"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("73ea3df9-5bcf-4a23-a60a-b8c645ce976a"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("74cca048-a681-4954-8b62-689a856cfa07"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("7bfdbd7a-b214-45be-aaeb-ce65921f5262"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("8bfe0139-17e9-42bb-b7ec-3c4f3a20b1ec"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("8c3e9ba7-bd92-47d5-93fc-2a1daecaa2e3"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("900239f7-c5e3-4e6a-84d5-7cb536aed4da"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("90536c78-f9f9-45e2-95bf-0289b87f5c71"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("ab3a4c1c-e519-41e5-988d-0ab00a103855"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("b9e51fce-5d2e-46c7-ae2c-65d71236c01e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("c0495cc3-5354-4cbd-9251-ef10ecdf321a"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("dbcc76a3-2043-49f9-b6a8-240fcea97eea"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e3dc2a2f-1a36-413f-9406-c1b63cd51d2d"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("ee3302d3-3dbf-4b2c-9c9e-45e7bb5f1c11"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f04ba061-6419-4301-9167-3cf8efddab59"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f2572e34-1cf2-46c1-9be5-c0ad230258d5"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f60b80b2-f14c-432d-a8da-317dfc1aed5b"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b33f-534b-4add-9735-d1eccb0f387f"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("fef30d07-4f6d-4632-83f1-2c3ca4654047"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4e644711-1d37-410c-af65-e7fa722d64a7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c127da08-1222-4d2b-afb2-a3ec31e66afd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28eb636a-8544-4370-9c54-062710899555"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6be76b5e-a23d-44f9-b700-7a93873cf84e"));

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
    }
}
