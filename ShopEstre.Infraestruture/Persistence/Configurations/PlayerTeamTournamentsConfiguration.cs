using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class PlayerTeamTournamentsConfiguration : IEntityTypeConfiguration<PlayerTeamTournaments>
    {
        public void Configure(EntityTypeBuilder<PlayerTeamTournaments> builder)
        {
            builder.ToTable("PlayerTeamTournaments");
            builder.HasKey(ptt => ptt.PlayerTeamTournamentId);

            // Configuración de la relación con Player
            builder.HasOne(ptt => ptt.Player)
                   .WithMany(p => p.TeamsByTournament)
                   .HasForeignKey(ptt => ptt.PlayerId);

            // Configuración de la relación con TournamentTeams
            builder.HasOne(ptt => ptt.TournamentTeam)
                   .WithMany()
                   .HasForeignKey(ptt => ptt.TournamentTeamId);

            builder.Property(ptt => ptt.IsActive).IsRequired();
        }
    }
}
