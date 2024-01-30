using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Games");
            builder.HasKey(g => g.GameId);

            // Configuración de la relación con LocalTeam
            builder.HasOne(g => g.LocalTeam)
                   .WithMany()
                   .HasForeignKey(g => g.LocalTeamId)
                   .OnDelete(DeleteBehavior.NoAction);

            // Configuración de la relación con VisitingTeam
            builder.HasOne(g => g.VisitingTeam)
                   .WithMany()
                   .HasForeignKey(g => g.VisitingTeamId)
                   .OnDelete(DeleteBehavior.NoAction); 

            builder.Property(g => g.StartDate).IsRequired();
            builder.Property(g => g.StartTime).IsRequired();
            builder.Property(g => g.Location).IsRequired();

        }
    }
}
