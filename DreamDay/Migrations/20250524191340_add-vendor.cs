using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamDay.Migrations
{
    /// <inheritdoc />
    public partial class addvendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("6ce772d3-66e7-46f9-a0c8-8247de6c8f3d"), null, "Admin", "ADMIN" },
                    { new Guid("7015f90d-0218-4298-bbc1-f17a9308a291"), null, "Vendor", "VENDOR" },
                    { new Guid("d8a2f24e-3eb7-49a5-ab24-96d6df4b8aff"), null, "Couple", "COUPLE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6d085755-312c-4359-8f8f-b3507b7e52f9"), 0, "1be7418e-a0a9-489b-a8ff-e5fd2003f92c", "admin@app.com", true, false, null, "ADMIN@APP.COM", "ADMIN", "AQAAAAIAAYagAAAAEKsBLm5xR7mFcL2guaEPYrBubeKuyk0DvEcNzLZOMPO3DJx4jFgYD3J9wO2m4vP/xw==", null, false, new DateTime(2025, 5, 25, 0, 43, 39, 436, DateTimeKind.Local).AddTicks(4538), "a599c83a-5362-49fc-8cd3-a84525692b6c", 1, false, "Admin" },
                    { new Guid("9b934ba7-1601-4508-8e67-f8e65b53309c"), 0, "76ae3dfb-2e65-42df-add7-d0ad344b9d15", "sam@app.com", true, false, null, "SAM@APP.COM", "COUPLE", "AQAAAAIAAYagAAAAECZCm5m825KLnMsTjDtlV/bqRc9OhYJG0BNDmVl4zO5JKzhSbNZd/I+ZrenrZdurlg==", null, false, new DateTime(2025, 5, 25, 0, 43, 39, 509, DateTimeKind.Local).AddTicks(40), "68dd03fb-b199-41d3-9ca3-8f571b01adb1", 1, false, "Couple" },
                    { new Guid("a4377ff6-fdbd-4489-ab7e-bd5e23a0c04b"), 0, "5a9d4147-a0ff-4927-8b61-814c3ef6fded", "vendor@app.com", true, false, null, "VENDOR@APP.COM", "VENDOR", "AQAAAAIAAYagAAAAELy84uAMbJodnd6vr7YofjPE/xz1b+c77tUwgFNe1Fk6mR1m4a1uap+dW0YMb/vdPA==", null, false, new DateTime(2025, 5, 25, 0, 43, 39, 584, DateTimeKind.Local).AddTicks(3597), "d0b24cfa-e241-4813-8ff1-5971252e4f36", 1, false, "Vendor" }
                });

            migrationBuilder.InsertData(
                table: "VendorTypes",
                columns: new[] { "Id", "Category", "VendorTypeName" },
                values: new object[,]
                {
                    { new Guid("1385cee0-22d2-452e-9539-04319778cb23"), 7, "Limousine Service" },
                    { new Guid("1a9ed280-5db1-4779-807a-171ac752fcce"), 3, "Invitations & Stationery" },
                    { new Guid("1d6e6a71-8543-4e15-af6f-dcfebca2edc4"), 6, "Open-Bar Service" },
                    { new Guid("27131a39-1a5e-4890-bb11-419aa4e3a45f"), 2, "DJ" },
                    { new Guid("3a2c0b78-abe2-4a4b-be5e-36af2ac7efe2"), 13, "First-Aid Staff" },
                    { new Guid("42b300e0-08e3-43f1-9ece-bfd87e1b8bf5"), 4, "Bridal Gown Designer" },
                    { new Guid("516b30fd-5026-46ac-b8ed-57a60ac3e2d3"), 14, "Tent Rental" },
                    { new Guid("56795154-3717-491e-ad4d-30261649fb9c"), 5, "Hair Stylist" },
                    { new Guid("57d50979-c0b5-4d72-b6ca-6562a72fd4ba"), 1, "Drone Photographer" },
                    { new Guid("5ec19779-36bd-4469-bdd9-40c601343136"), 3, "Favors & Gifts" },
                    { new Guid("6091c11f-edda-4a7d-832e-22bc9e3e1154"), 7, "Vintage Car Rental" },
                    { new Guid("62040416-9288-4953-8a44-e56acc35d728"), 6, "Caterer" },
                    { new Guid("6797a7d6-ae4f-4c97-9f50-4484b09f012b"), 8, "Floral Arrangements" },
                    { new Guid("74087553-325e-47cf-bb10-d592298a72ac"), 11, "Fire Dancers" },
                    { new Guid("774ead50-7c6a-4bde-abc0-f97e33290b6e"), 14, "Chair & Table Rental" },
                    { new Guid("826fcd85-567f-4815-a606-ad05fb6507d8"), 12, "Lighting Designer" },
                    { new Guid("90515128-47db-4ef7-96e3-24a83ed975dd"), 2, "Live Band" },
                    { new Guid("986e7853-7682-4841-b33f-3029288472a8"), 1, "Videographer" },
                    { new Guid("9a1a1e10-26d7-4d2e-9054-22f416b71b77"), 15, "Banquet Hall" },
                    { new Guid("a0f2be61-4374-4a36-b120-3d01070c38be"), 15, "Beachfront Venue" },
                    { new Guid("a14d7f85-eeea-484c-aa59-6bb791dbb20c"), 10, "Full-Service Planner" },
                    { new Guid("a97412b6-789e-4076-ada3-22f89e302eec"), 9, "Dessert Station" },
                    { new Guid("badd07e7-95e5-455b-93d2-d2979b84c6d9"), 1, "Photographer" },
                    { new Guid("c1dc29e8-03bb-44f9-88f5-4799327ad2ac"), 10, "Day-Of Coordinator" },
                    { new Guid("c335b50a-16a9-4d26-9857-394c1b130fb7"), 5, "Makeup Artist" },
                    { new Guid("cc19297c-5f03-47f6-8c0b-b13b1f9d6721"), 11, "String Quartet" },
                    { new Guid("d827d15d-f23f-4f0c-80b2-6c14a318b370"), 9, "Wedding Cake Designer" },
                    { new Guid("dd5b3d89-4998-4680-98ac-fee7c04a2cce"), 12, "Sound Engineer" },
                    { new Guid("e361d354-84d3-408c-b2aa-d6f086eaeb97"), 4, "Jewelry Boutique" },
                    { new Guid("f2f0cf74-8462-46b8-bb4f-96212bdc2438"), 8, "Event Draping" },
                    { new Guid("f37c6f8d-94d4-4130-ae62-ec7792b54739"), 13, "Event Security" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6ce772d3-66e7-46f9-a0c8-8247de6c8f3d"), new Guid("6d085755-312c-4359-8f8f-b3507b7e52f9") },
                    { new Guid("d8a2f24e-3eb7-49a5-ab24-96d6df4b8aff"), new Guid("9b934ba7-1601-4508-8e67-f8e65b53309c") },
                    { new Guid("7015f90d-0218-4298-bbc1-f17a9308a291"), new Guid("a4377ff6-fdbd-4489-ab7e-bd5e23a0c04b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6ce772d3-66e7-46f9-a0c8-8247de6c8f3d"), new Guid("6d085755-312c-4359-8f8f-b3507b7e52f9") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d8a2f24e-3eb7-49a5-ab24-96d6df4b8aff"), new Guid("9b934ba7-1601-4508-8e67-f8e65b53309c") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7015f90d-0218-4298-bbc1-f17a9308a291"), new Guid("a4377ff6-fdbd-4489-ab7e-bd5e23a0c04b") });

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("1385cee0-22d2-452e-9539-04319778cb23"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("1a9ed280-5db1-4779-807a-171ac752fcce"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("1d6e6a71-8543-4e15-af6f-dcfebca2edc4"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("27131a39-1a5e-4890-bb11-419aa4e3a45f"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a2c0b78-abe2-4a4b-be5e-36af2ac7efe2"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("42b300e0-08e3-43f1-9ece-bfd87e1b8bf5"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("516b30fd-5026-46ac-b8ed-57a60ac3e2d3"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("56795154-3717-491e-ad4d-30261649fb9c"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("57d50979-c0b5-4d72-b6ca-6562a72fd4ba"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("5ec19779-36bd-4469-bdd9-40c601343136"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("6091c11f-edda-4a7d-832e-22bc9e3e1154"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("62040416-9288-4953-8a44-e56acc35d728"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("6797a7d6-ae4f-4c97-9f50-4484b09f012b"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("74087553-325e-47cf-bb10-d592298a72ac"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("774ead50-7c6a-4bde-abc0-f97e33290b6e"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("826fcd85-567f-4815-a606-ad05fb6507d8"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("90515128-47db-4ef7-96e3-24a83ed975dd"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("986e7853-7682-4841-b33f-3029288472a8"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("9a1a1e10-26d7-4d2e-9054-22f416b71b77"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("a0f2be61-4374-4a36-b120-3d01070c38be"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("a14d7f85-eeea-484c-aa59-6bb791dbb20c"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("a97412b6-789e-4076-ada3-22f89e302eec"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("badd07e7-95e5-455b-93d2-d2979b84c6d9"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("c1dc29e8-03bb-44f9-88f5-4799327ad2ac"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("c335b50a-16a9-4d26-9857-394c1b130fb7"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("cc19297c-5f03-47f6-8c0b-b13b1f9d6721"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("d827d15d-f23f-4f0c-80b2-6c14a318b370"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("dd5b3d89-4998-4680-98ac-fee7c04a2cce"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("e361d354-84d3-408c-b2aa-d6f086eaeb97"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f2f0cf74-8462-46b8-bb4f-96212bdc2438"));

            migrationBuilder.DeleteData(
                table: "VendorTypes",
                keyColumn: "Id",
                keyValue: new Guid("f37c6f8d-94d4-4130-ae62-ec7792b54739"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ce772d3-66e7-46f9-a0c8-8247de6c8f3d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7015f90d-0218-4298-bbc1-f17a9308a291"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d8a2f24e-3eb7-49a5-ab24-96d6df4b8aff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d085755-312c-4359-8f8f-b3507b7e52f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b934ba7-1601-4508-8e67-f8e65b53309c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4377ff6-fdbd-4489-ab7e-bd5e23a0c04b"));

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
    }
}
