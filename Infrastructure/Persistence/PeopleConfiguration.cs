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
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            
            builder.HasKey(x => x.PeopleID);
            builder.Property(x => x.PeopleID).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PeopleName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.MobileNo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PeopleCode).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Created)
                                    .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                                    .ValueGeneratedOnAdd();
            builder.Property(x => x.Modified)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAddOrUpdate();

            // Relation with User
            builder.HasOne(x => x.User)
                   .WithMany(u => u.Peoples)
                   .HasForeignKey(x => x.UserID)
                   .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
