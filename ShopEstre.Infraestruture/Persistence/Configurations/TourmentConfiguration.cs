using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Enums;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class TourmentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.ToTable("Tournaments");
            builder.HasKey(t => t.TournamentId);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.CreatedDate).IsRequired();
            builder.Property(t => t.StartDate).IsRequired();
            builder.Property(t => t.Description).IsRequired();
            builder.Property(t => t.Type)
                   .IsRequired()
                   .HasConversion(
                       type => (int)type,
                       value => (EnumTypeTourment)value
                   );

            // Configuración de la relación con TournamentState
            builder.HasOne(t => t.TournamentState)
                   .WithOne()
                   .HasForeignKey<Tournament>(t => t.TournamentStateId);



        }
    }
}
