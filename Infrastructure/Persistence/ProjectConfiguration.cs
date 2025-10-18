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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.ProjectID);
            builder.Property(x => x.ProjectID).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ProjectName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ProjectLogo).HasMaxLength(500);
            builder.Property(x => x.ProjectDetail).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Created)
                                  .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                                  .ValueGeneratedOnAdd();
            builder.Property(x => x.Modified)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAddOrUpdate();
            builder.HasOne(x => x.User)
                   .WithMany(u => u.Projects)
                   .HasForeignKey(x => x.UserID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
