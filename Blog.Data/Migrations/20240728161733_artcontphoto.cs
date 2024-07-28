using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class artcontphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("74e83546-5fe7-41bb-afbd-8bb304bf6392"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cc59b934-0f7b-497c-8b50-96164e0097f8"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "ImagePath", "IsDeleted", "ModifiedBy", "ModifiedDate", "Status", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6fbc6c87-bea8-4aaf-b3bf-26d01f7c0022"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 28, 20, 17, 32, 797, DateTimeKind.Local).AddTicks(5038), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), "/images/ArticleContentPhoto/", false, null, null, null, ".net Framework Content", new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"), 15 },
                    { new Guid("70610061-e43d-471e-a34c-bdd0aa2a0bea"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 28, 20, 17, 32, 797, DateTimeKind.Local).AddTicks(5030), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), "/images/ArticleContentPhoto/", false, null, null, null, "Asp.Net Content", new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("143f726a-600f-47b8-933e-687a8936b943"),
                column: "ConcurrencyStamp",
                value: "4dc17d47-ade8-43be-bab1-dc0483097199");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f72885a-fcd8-4d2e-ba7a-8220f5e3c213"),
                column: "ConcurrencyStamp",
                value: "2ed8b5a1-cca1-4f54-b5d8-a54b3e64ffba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("971d808b-e1c8-4212-94e8-5a6f61610970"),
                column: "ConcurrencyStamp",
                value: "7e9f8d24-85b2-4976-b945-90c3689ee17a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f0194e-049f-4373-a1c6-580737ed859e", "AQAAAAEAACcQAAAAEBL1mPrr1lJWZ0xd08LMRKubOv5F4ay/3UO2zwel0/jUqEuMDurcchJkei/ghFXbmQ==", "6067f62c-eae5-41a5-93d7-20a5a56db8d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b0852a5-9ed5-4779-b61a-5234b551b97a", "AQAAAAEAACcQAAAAEMadFdx7Naw5aDU/lwrcvdJ/4oA/c0eMpM092aw7EB8W8T/ZDSW5Fqe+nvjKx6xrkA==", "9c8a3a5d-fce8-4998-a359-6dc929d84b29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 20, 17, 32, 797, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 20, 17, 32, 797, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 20, 17, 32, 797, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 20, 17, 32, 797, DateTimeKind.Local).AddTicks(5676));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6fbc6c87-bea8-4aaf-b3bf-26d01f7c0022"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("70610061-e43d-471e-a34c-bdd0aa2a0bea"));

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Status", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("74e83546-5fe7-41bb-afbd-8bb304bf6392"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 28, 17, 31, 29, 910, DateTimeKind.Local).AddTicks(3045), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, null, "Asp.Net Content", new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"), 15 },
                    { new Guid("cc59b934-0f7b-497c-8b50-96164e0097f8"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 28, 17, 31, 29, 910, DateTimeKind.Local).AddTicks(3057), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, null, ".net Framework Content", new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("143f726a-600f-47b8-933e-687a8936b943"),
                column: "ConcurrencyStamp",
                value: "8b748e4a-88cd-4766-8468-31c6e46049c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f72885a-fcd8-4d2e-ba7a-8220f5e3c213"),
                column: "ConcurrencyStamp",
                value: "e29adf7f-f313-464f-af9e-97307d45c8b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("971d808b-e1c8-4212-94e8-5a6f61610970"),
                column: "ConcurrencyStamp",
                value: "41b2a14d-29af-4ae4-a6aa-f34b1afb9d3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d14055b-6993-44e7-b8bf-61fdf0c42ef7", "AQAAAAEAACcQAAAAEJxeouW6SnrrvmhDtadh+ACy3BPDaTuTIOOlzh+YLhZn7Eia/VBZUy/EM23I8hXLGg==", "4ed26caf-f915-42f6-ab17-a94e43158167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d80a62a-2522-449a-b95a-c00193068ea4", "AQAAAAEAACcQAAAAEC/pT/BdNYIuE59/wZApU+ZGizqeIZvz1GQ0DAnx9mxG6c2nQ69XBue9vIHRZYa0lA==", "2813db93-27f4-4536-af41-1e611aa81138" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 17, 31, 29, 910, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 17, 31, 29, 910, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 17, 31, 29, 910, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 28, 17, 31, 29, 910, DateTimeKind.Local).AddTicks(3486));
        }
    }
}
