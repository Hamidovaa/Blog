using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DalExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5aa57647-304b-475f-90ae-8f7c74513eb0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a8931bab-502b-4320-9017-8582f10321bc"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b0a96fd1-3543-4afb-be86-a3dd007a6ec3"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 26, 0, 24, 45, 548, DateTimeKind.Local).AddTicks(7860), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, "Asp.Net Content", 15 },
                    { new Guid("b30fabbe-705f-416b-bd83-b6e049ac39b4"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 26, 0, 24, 45, 548, DateTimeKind.Local).AddTicks(7868), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, ".net Framework Content", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 0, 24, 45, 548, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 0, 24, 45, 548, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 0, 24, 45, 548, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 0, 24, 45, 548, DateTimeKind.Local).AddTicks(8323));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b0a96fd1-3543-4afb-be86-a3dd007a6ec3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b30fabbe-705f-416b-bd83-b6e049ac39b4"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5aa57647-304b-475f-90ae-8f7c74513eb0"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8568), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, "Asp.Net Content", 15 },
                    { new Guid("a8931bab-502b-4320-9017-8582f10321bc"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8579), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, ".net Framework Content", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 25, 23, 1, 0, 405, DateTimeKind.Local).AddTicks(9347));
        }
    }
}
