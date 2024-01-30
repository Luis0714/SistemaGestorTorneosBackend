using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.ValueObjects;
using System.Reflection.Emit;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(user => user.UserId);
            builder.Property(user => user.Name);
            builder.Property(user => user.LastName);
            builder.HasIndex(user => user.Email).IsUnique();

            builder.Property(user => user.Password).HasConversion(
                password => password.Value,
                value => Password.Create(value)!).HasMaxLength(80);

            builder.Property(c => c.PhoneNumber).HasConversion(
                phoneNumber => phoneNumber.Value,
                value => PhoneNumber.Create(value)!).HasMaxLength(20);

            builder.HasOne(user => user.Role)
                   .WithMany(role => role.Users)
                   .HasForeignKey(user => user.RoleId);

           builder.HasOne(u => u.Player)
           .WithOne(p => p.User)
           .HasForeignKey<Player>(p => p.PlayerId);
        }
    }
}
