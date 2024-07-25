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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("7D1DB20D-6903-4493-A0D9-0CC426A86FE4"),
                Name = "Asp .Net",
                CreatedBy = "Admin Test",
                CreateDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("B77EF121-DE5A-45A6-811A-1D6A82000E44"),
                Name = " .Net",
                CreatedBy = "Admin Test",
                CreateDate = DateTime.Now,
                IsDeleted = false
            }
            );
        }
    }
}
