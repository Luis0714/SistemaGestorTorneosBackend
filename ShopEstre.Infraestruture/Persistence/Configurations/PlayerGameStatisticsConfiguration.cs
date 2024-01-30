using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class PlayerGameStatisticsConfiguration : IEntityTypeConfiguration<PlayerGameStatistics>
    {
        public void Configure(EntityTypeBuilder<PlayerGameStatistics> builder)
        {
            builder.ToTable("PlayerGameStatistics");
            builder.HasKey(pgs => pgs.PlayerGameStatisticsId);

            // Configuración de la relación con PlayerGame
            builder.HasOne(pgs => pgs.PlayerGame)
                   .WithMany(pg => pg.PlayerGameStatistics)
                   .HasForeignKey(pgs => pgs.PlayerGameId);

            builder.Property(pgs => pgs.Scores).IsRequired();
            builder.Property(pgs => pgs.YellowCards).IsRequired();
            builder.Property(pgs => pgs.RedCards).IsRequired();
        }
    }
}
