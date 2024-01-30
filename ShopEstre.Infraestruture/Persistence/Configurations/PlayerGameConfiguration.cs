using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class PlayerGameConfiguration : IEntityTypeConfiguration<PlayerGame>
    {
        public void Configure(EntityTypeBuilder<PlayerGame> builder)
        {
            builder.ToTable("PlayerGames");
            builder.HasKey(pg => pg.PlayerGameId);

            // Configuración de la relación con Game
            builder.HasOne(pg => pg.Game)
                   .WithMany()
                   .HasForeignKey(pg => pg.GameId);

            // Configuración de la relación con PlayerTeamTournaments
            builder.HasOne(pg => pg.PlayerTeamTournament)
                   .WithMany()
                   .HasForeignKey(pg => pg.PlayerTeamTournamentId);

            builder.Property(pg => pg.IsStarter).IsRequired();
        }
    }
}
