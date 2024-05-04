using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class ProductImageEntity : EntityBase
    {
        public int ProductId { get; set; }
        public string Url { get; set; } = null!;

        //Navigation properties

        public ProductEntity Product { get; set; } = null!;
    }

    internal class ProductImageEntityConfiguration : IEntityTypeConfiguration<ProductImageEntity>
    {
        public void Configure(EntityTypeBuilder<ProductImageEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.Url).IsRequired().HasMaxLength(250);
            builder.Property(e => e.CreatedAt).IsRequired();

            builder.HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
