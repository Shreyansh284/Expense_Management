using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class UserConfiguration :IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
     
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.UserID).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.MobileNo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ProfileImage).HasMaxLength(500);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Created)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAdd();
            builder.Property(x => x.Modified)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAddOrUpdate();
        }

    }
}
