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
    public class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryID);
            builder.Property(x => x.CategoryID).ValueGeneratedOnAdd();
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LogoPath).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x=>x.IsExpense).HasDefaultValue(true);
            builder.Property(x=>x.IsIncome).HasDefaultValue(true);
            builder.Property(x => x.Created)
                                  .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                                  .ValueGeneratedOnAdd();
            builder.Property(x => x.Modified)
                               .HasDefaultValueSql("DATEADD(MINUTE, 330, GETUTCDATE())")
                               .ValueGeneratedOnAddOrUpdate();

            builder.HasOne(x => x.User)
                   .WithMany(u => u.Categories)
                   .HasForeignKey(x => x.UserID)
                   .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
