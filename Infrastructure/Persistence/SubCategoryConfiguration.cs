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
    public class SubCategoryConfiguration :IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {

            builder.HasKey(x => x.SubCategoryID);
            builder.Property(x => x.SubCategoryID).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.SubCategoryName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LogoPath).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsExpense).HasDefaultValue(true);
            builder.Property(x => x.IsIncome).HasDefaultValue(true);
            builder.Property(x=>x.Sequence).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Created)
                                  .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                                  .ValueGeneratedOnAdd();
            builder.Property(x => x.Modified)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAddOrUpdate();

            // Relation with Category
            builder.HasOne(x => x.Category)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(x => x.CategoryID)
                   .OnDelete(DeleteBehavior.Cascade);

            // Relation with User
            builder.HasOne(x => x.User)
                   .WithMany(u => u.SubCategories)
                   .HasForeignKey(x => x.UserID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}