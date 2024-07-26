using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7f2ab3b7-cf8f-435b-a9d7-ef000fcdf0f0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("db177a4c-2862-4326-8902-781f5f1a6cd9"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Status", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("de733658-2b21-4607-b787-0965dc9be5f6"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 27, 0, 46, 50, 736, DateTimeKind.Local).AddTicks(1440), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, null, "Asp.Net Content", new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"), 15 },
                    { new Guid("e530015c-4ee8-40b0-bccc-78ad960ba3d3"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 27, 0, 46, 50, 736, DateTimeKind.Local).AddTicks(1453), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, null, ".net Framework Content", new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("143f726a-600f-47b8-933e-687a8936b943"),
                column: "ConcurrencyStamp",
                value: "0b2e2ef3-18f2-4a3b-a46e-6874c59a09de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f72885a-fcd8-4d2e-ba7a-8220f5e3c213"),
                column: "ConcurrencyStamp",
                value: "1bd9fcae-1191-408c-a2c1-b44cd70d3e0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("971d808b-e1c8-4212-94e8-5a6f61610970"),
                column: "ConcurrencyStamp",
                value: "8c0f921d-6eba-4ab9-af10-add310ca66ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "625cfee2-f508-4719-be1d-eede3ae21de9", "AQAAAAEAACcQAAAAEBMFTK6fU4NNjonjCWhjKwriiBt2D9MAd4p/eL7u4qNNBMOS9/csgOl2P/H2UybJPQ==", "27d7e502-b314-44f6-b1ad-c0fc32e8bf74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c0cf94e-d39f-4663-939d-f9f2d72da362", "AQAAAAEAACcQAAAAEGW2HYEcfpUnk8kL9rkaL40t5ZhJZz4peX0/jD81wz43bavVe7qJ3KoOSACvrGQ4ug==", "60b95f99-7ddf-4146-b7e6-cf8ab633e663" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 27, 0, 46, 50, 736, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 27, 0, 46, 50, 736, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 27, 0, 46, 50, 736, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 27, 0, 46, 50, 736, DateTimeKind.Local).AddTicks(1868));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("de733658-2b21-4607-b787-0965dc9be5f6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e530015c-4ee8-40b0-bccc-78ad960ba3d3"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7f2ab3b7-cf8f-435b-a9d7-ef000fcdf0f0"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 26, 17, 23, 4, 17, DateTimeKind.Local).AddTicks(2764), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, ".net Framework Content", new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"), 15 },
                    { new Guid("db177a4c-2862-4326-8902-781f5f1a6cd9"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 26, 17, 23, 4, 17, DateTimeKind.Local).AddTicks(2751), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, "Asp.Net Content", new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("143f726a-600f-47b8-933e-687a8936b943"),
                column: "ConcurrencyStamp",
                value: "a61539f4-3ab9-441b-b268-5bbfa6acbc53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f72885a-fcd8-4d2e-ba7a-8220f5e3c213"),
                column: "ConcurrencyStamp",
                value: "99703fb5-1775-4813-b794-63cdce4dda5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("971d808b-e1c8-4212-94e8-5a6f61610970"),
                column: "ConcurrencyStamp",
                value: "c2d25293-4a82-4bcb-a125-a26a4c12c470");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e3b12c-2f9b-4fad-99d9-30c1c9b37b3e", "AQAAAAEAACcQAAAAEKDPL+FeyY/c2X5xH/Ds5FAxnSqDLIjdQh/A+DA3OoOR2ZK65nJq7ls/oqnUIlvnqQ==", "72ba34d7-709d-40d7-bdd1-1f7bffc66f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94bd6732-c4a7-4f41-bcc5-5c3da9080179", "AQAAAAEAACcQAAAAEH64HTUZUo3PdtgSjehgJIrEVw5Ta8rXl+qi2H1oIGFCyUuaUOlJSO+lbwEVt+hs2g==", "39fa5251-b5f5-4db4-b75b-ea5e2692ae27" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 17, 23, 4, 17, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 17, 23, 4, 17, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 17, 23, 4, 17, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 17, 23, 4, 17, DateTimeKind.Local).AddTicks(3301));
        }
    }
}
