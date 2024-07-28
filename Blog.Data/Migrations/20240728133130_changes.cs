using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("de733658-2b21-4607-b787-0965dc9be5f6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e530015c-4ee8-40b0-bccc-78ad960ba3d3"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("74e83546-5fe7-41bb-afbd-8bb304bf6392"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cc59b934-0f7b-497c-8b50-96164e0097f8"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
