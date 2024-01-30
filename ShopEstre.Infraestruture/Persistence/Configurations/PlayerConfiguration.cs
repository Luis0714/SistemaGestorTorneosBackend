using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey(player => player.PlayerId);
            builder.Property(player => player.Name);
            builder.Property(player => player.Age);
            builder.Property(player => player.LastName);
            builder.Property(player => player.Number);
            builder.Property(player => player.DateOfBirth);
            builder.Property(player => player.Photo).IsRequired(false);

            builder.HasOne(player => player.User)
                   .WithOne(user => user.Player)
                   .HasForeignKey<Player>(player => player.UserId);
        }
    }

}
