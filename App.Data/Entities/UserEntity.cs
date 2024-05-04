using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class UserEntity : EntityBase
    {

        public string Email { get; set; } = null!;

        [MinLength(2)]
        public string FirstName { get; set; } = null!;

        [MinLength(2)]
        public string LastName { get; set; } = null!;

        [MinLength(2)]
        public string Password { get; set; } = null!;

        public int RoleId { get; set; }
        public bool Enabled { get; set; } = true;

        // Navigation properties
        public RoleEntity Role { get; set; } = null!;
    }

    internal class  UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Email).HasMaxLength(50).IsRequired();
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(e => e.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Password).HasMaxLength(50).IsRequired();
            builder.Property(e => e.RoleId).IsRequired();
            builder.Property(e => e.Enabled).IsRequired().HasDefaultValue(true);
            builder.Property(e => e.CreatedAt).IsRequired();

            builder.HasOne(e => e.Role)
                .WithMany()
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
