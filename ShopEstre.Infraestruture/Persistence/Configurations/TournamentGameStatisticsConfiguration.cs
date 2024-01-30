using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class TournamentGameStatisticsConfiguration : IEntityTypeConfiguration<TournamentGameStatistics>
    {
        public void Configure(EntityTypeBuilder<TournamentGameStatistics> builder)
        {
            builder.ToTable("TournamentGameStatistics");
            builder.HasKey(tgs => tgs.TournamentGameStatisticsId);

            // Configuración de la relación con Game
            builder.HasOne(tgs => tgs.Game)
                   .WithOne()
                   .HasForeignKey<TournamentGameStatistics>(tgs => tgs.GameId);

            builder.Property(tgs => tgs.LocalTeamScores).IsRequired();
            builder.Property(tgs => tgs.VisitingScores).IsRequired();
        }
    }
}
