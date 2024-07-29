using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class changesnotmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("640c4bfb-15c1-45e2-b170-dd6d4663e5e6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e34e21ec-c095-4b4f-9625-747eaaa45998"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "ImagePath", "IsDeleted", "ModifiedBy", "ModifiedDate", "Status", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("11b828ee-6e69-4d43-878b-e9c77414cc1f"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 29, 14, 33, 32, 301, DateTimeKind.Local).AddTicks(4549), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), "/images/ArticleContentPhoto/", false, null, null, null, "Asp.Net Content", new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"), 15 },
                    { new Guid("46b9c8d5-c599-4400-a674-b2b21f2b27fc"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 29, 14, 33, 32, 301, DateTimeKind.Local).AddTicks(4616), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), "/images/ArticleContentPhoto/", false, null, null, null, ".net Framework Content", new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("143f726a-600f-47b8-933e-687a8936b943"),
                column: "ConcurrencyStamp",
                value: "b5935f67-20d7-4904-b27f-5339afd59b96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f72885a-fcd8-4d2e-ba7a-8220f5e3c213"),
                column: "ConcurrencyStamp",
                value: "206488b9-1b7f-40c4-a5b5-88320d008f55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("971d808b-e1c8-4212-94e8-5a6f61610970"),
                column: "ConcurrencyStamp",
                value: "8a2549fd-b966-4742-b068-ad205d8f2b78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"),
                columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a5531b7-e5fd-4240-acd9-2c82982a1013", new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), "AQAAAAEAACcQAAAAEK9Np7qofaerLpKhV1BgJt7/tuPzcAhxROGh5OguRUxfh5+5cEpJHSbLmgEulx+F8g==", "53e09c51-4bae-4998-890e-fbdae3054643" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"),
                columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72340da7-ed82-498d-9066-c5d68957cd16", new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), "AQAAAAEAACcQAAAAENXy4eJc8qs9o+ctoPODbaaqRVkQsZw6/CLrEA6NGIwG8EMG7sp5vFmJMtSIYJiB2w==", "c362710e-e76d-4b5c-84b0-98eb0b296f09" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 29, 14, 33, 32, 301, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 29, 14, 33, 32, 301, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 29, 14, 33, 32, 301, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 29, 14, 33, 32, 301, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("11b828ee-6e69-4d43-878b-e9c77414cc1f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("46b9c8d5-c599-4400-a674-b2b21f2b27fc"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
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
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "CreatedBy", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("640c4bfb-15c1-45e2-b170-dd6d4663e5e6"), new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"), ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 26, 16, 31, 12, 603, DateTimeKind.Local).AddTicks(5550), "Admin", null, null, new Guid("95b73123-ead5-423b-a029-3672225a1e1b"), false, null, null, ".net Framework Content", 15 },
                    { new Guid("e34e21ec-c095-4b4f-9625-747eaaa45998"), new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"), "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.", new DateTime(2024, 7, 26, 16, 31, 12, 603, DateTimeKind.Local).AddTicks(5544), "Admin", null, null, new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"), false, null, null, "Asp.Net Content", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("143f726a-600f-47b8-933e-687a8936b943"),
                column: "ConcurrencyStamp",
                value: "c3b6f6b6-3f0e-41a2-80ea-f5661efd4490");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f72885a-fcd8-4d2e-ba7a-8220f5e3c213"),
                column: "ConcurrencyStamp",
                value: "f93a7fba-6eab-40a5-93d2-4d85701a3923");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("971d808b-e1c8-4212-94e8-5a6f61610970"),
                column: "ConcurrencyStamp",
                value: "79bc935b-a680-4fce-8a93-7a0fddbd9e58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a55f1-fe1c-4a59-b737-6a6dbff724e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be476ad8-9a2d-43a2-935e-9df8263a8afa", "AQAAAAEAACcQAAAAEDHV+2GSpeI+dwlsIBS63mDMCckqei5aJHWXIWiW6cPful0pQ/5gGhF8Z6YVa0vcjA==", "bbd5a128-1fb0-459f-93ad-fb1a53665dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a05e2229-ae92-4a3f-a889-75c00fc64bf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "066ace0f-31c9-457d-8085-90f0c1cb560c", "AQAAAAEAACcQAAAAEOxVO7WW+1r00boc1qIZtfImIbjfUasIgZczh7Z7z395QuaRU4eHf/qxgNzKDAZBhQ==", "21fd72aa-1741-4902-b77f-9e8f62e4de13" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d1db20d-6903-4493-a0d9-0cc426a86fe4"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 16, 31, 12, 603, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b77ef121-de5a-45a6-811a-1d6a82000e44"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 16, 31, 12, 603, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("95b73123-ead5-423b-a029-3672225a1e1b"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 16, 31, 12, 603, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("98e993c4-de3c-4aba-afc6-e62046867fdd"),
                column: "CreateDate",
                value: new DateTime(2024, 7, 26, 16, 31, 12, 603, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
