using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class ProductEntity : EntityBase
    {
        public int SellerId { get; set; }
        public int CategoryId { get; set; }

        [MinLength(2)]
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Details { get; set; } = null!;
        public byte StockAmount { get; set; }
        public bool Enabled { get; set; } = true;

        // Navigation properties
        public UserEntity Seller { get; set; } = null!;
        public CategoryEntity Category { get; set; } = null!;
    }

    internal class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.SellerId).IsRequired();
            builder.Property(e => e.CategoryId).IsRequired();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(e => e.Details).HasMaxLength(1000);
            builder.Property(e => e.StockAmount).IsRequired();
            builder.Property(e => e.CreatedAt).IsRequired();
            builder.Property(e => e.Enabled).IsRequired().HasDefaultValue(true);

            builder.HasOne(d => d.Seller)
                .WithMany()
                .HasForeignKey(d => d.SellerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(d => d.Category)
                .WithMany()
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
