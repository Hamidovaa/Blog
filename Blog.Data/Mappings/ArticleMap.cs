using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x => x.Title).HasMaxLength(200);

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Content",
                Content = "ASP.NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.",
                ViewCount = 15,
                
                CategoryId = Guid.Parse("7D1DB20D-6903-4493-A0D9-0CC426A86FE4"),
            
                ImageId=Guid.Parse("98E993C4-DE3C-4ABA-AFC6-E62046867FDD"),
                CreatedBy = "Admin",
                CreateDate = DateTime.Now,
                IsDeleted = false,
                UserId= Guid.Parse("5D5A55F1-FE1C-4A59-B737-6A6DBFF724E1"),
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = ".net Framework Content",
                Content = ".NET Core supports industry standard authentication protocols. Built-in features help protect your apps against cross-site scripting (XSS) and cross-site request forgery (CSRF).\r\n\r\nASP.NET Core provides a built-in user database with support for multi-factor authentication and external authentication with Google, X, and more.",
                ViewCount = 15,
                CategoryId= Guid.Parse("B77EF121-DE5A-45A6-811A-1D6A82000E44"),
                ImageId=Guid.Parse("95B73123-EAD5-423B-A029-3672225A1E1B"),
                CreatedBy = "Admin",
                CreateDate = DateTime.Now,
                UserId= Guid.Parse("A05E2229-AE92-4A3F-A889-75C00FC64BF3"),
            }
            );
            
        }
    }
}
