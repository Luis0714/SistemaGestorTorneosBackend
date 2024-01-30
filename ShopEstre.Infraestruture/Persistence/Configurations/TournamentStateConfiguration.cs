using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class TournamentStateConfiguration : IEntityTypeConfiguration<TournamentState>
    {
        public void Configure(EntityTypeBuilder<TournamentState> builder)
        {
            builder.ToTable("TournamentStates");
            builder.HasKey(ts => ts.TournamentStateId);
            builder.Property(ts => ts.Name).IsRequired();
            builder.Property(ts => ts.Description).IsRequired();
        }
    }
}
