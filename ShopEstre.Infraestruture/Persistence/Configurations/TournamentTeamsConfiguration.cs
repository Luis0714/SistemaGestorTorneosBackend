using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class TournamentTeamsConfiguration : IEntityTypeConfiguration<TournamentTeams>
    {
        public void Configure(EntityTypeBuilder<TournamentTeams> builder)
        {
            builder.ToTable("TournamentTeams");
            builder.HasKey(tt => tt.TourmentTeamsId);
            builder.HasOne(tt => tt.Tournament)
                   .WithMany(t => t.TournamentTeams)
                   .HasForeignKey(tt => tt.TournamentId);
            builder.HasOne(tt => tt.Team)
                   .WithMany(t => t.TournamentTeams)
                   .HasForeignKey(tt => tt.TeamId);
            builder.Property(tt => tt.IsActive).IsRequired();
        }
    }
}

