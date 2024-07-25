using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8957), "Admin Test", null, null, false, null, null, "Asp .Net" },
                    { new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8964), "Admin Test", null, null, false, null, null, " .Net" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(9397), "Admin", null, null, "images/nettestimages", "png", false, null, null },
                    { new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(9347), "Admin", null, null, "images/testimages", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("5aa57647-304b-475f-90ae-8f7c74513eb0"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8568), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, "Asp.Net Content", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("a8931bab-502b-4320-9017-8582f10321bc"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8579), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, ".net Framework Content", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5aa57647-304b-475f-90ae-8f7c74513eb0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a8931bab-502b-4320-9017-8582f10321bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
