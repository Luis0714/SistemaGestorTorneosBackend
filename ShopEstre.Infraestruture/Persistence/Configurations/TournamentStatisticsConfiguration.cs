using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class TournamentStatisticsConfiguration : IEntityTypeConfiguration<TournamentStatistics>
    {
        public void Configure(EntityTypeBuilder<TournamentStatistics> builder)
        {
            builder.ToTable("TournamentStatistics");
            builder.HasKey(ts => ts.TournametStatisticsId);

            // Configuración de la relación con TournamentTeams
            builder.HasOne(ts => ts.TounamentTeam)
                   .WithMany()
                   .HasForeignKey(ts => ts.TounamentTeamsId);

            builder.Property(ts => ts.Position).IsRequired();
            builder.Property(ts => ts.GamesPlayed).IsRequired();
            builder.Property(ts => ts.MatchesWon).IsRequired();
            builder.Property(ts => ts.MatchesTied).IsRequired();
            builder.Property(ts => ts.MatchesLost).IsRequired();
            builder.Property(ts => ts.GoalsScored).IsRequired();
            builder.Property(ts => ts.GoalsReceived).IsRequired();
            builder.Property(ts => ts.DifferenceGoals).IsRequired();
            builder.Property(ts => ts.Points).IsRequired();
        }
    }
}
