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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("5D5A55F1-FE1C-4A59-B737-6A6DBFF724E1"),
                RoleId = Guid.Parse("8F72885A-FCD8-4D2E-BA7A-8220F5E3C213"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("A05E2229-AE92-4A3F-A889-75C00FC64BF3"),
                RoleId = Guid.Parse("971D808B-E1C8-4212-94E8-5A6F61610970"),
            }
            );
        }
    }
}
