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
    public class IncomeConfiguartion : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {

            builder.HasKey(x => x.IncomeID);
            builder.Property(x => x.IncomeID).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.IncomeDetail).HasMaxLength(500);
            builder.Property(x => x.AttachmentPath).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Created)
                                       .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                                       .ValueGeneratedOnAdd();
            builder.Property(x => x.Modified)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAddOrUpdate();

            builder.HasOne(x => x.Category)
                   .WithMany()
                   .HasForeignKey(x => x.CategoryID)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.SubCategory)
                   .WithMany()
                   .HasForeignKey(x => x.SubCategoryID)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.People)
                   .WithMany()
                   .HasForeignKey(x => x.PeopleID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                   .WithMany()
                   .HasForeignKey(x => x.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Project)
                   .WithMany()
                   .HasForeignKey(x => x.ProjectID)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
 }
