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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
            
                    Id = Guid.Parse("98E993C4-DE3C-4ABA-AFC6-E62046867FDD"),
                FileName = "images/testimages",
                    FileType = "jpg",
                    CreatedBy = "Admin",
                    CreateDate = DateTime.Now,
                    IsDeleted = false
               

            },
            new Image
            {
                Id = Guid.Parse("95B73123-EAD5-423B-A029-3672225A1E1B"),
                FileName = "images/nettestimages",
                FileType = "png",
                CreatedBy = "Admin",
                CreateDate = DateTime.Now,
                IsDeleted = false
            }
            );
        }
    }
}
