using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Infraestruture.Persistence.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Teams");
            builder.HasKey(t => t.TeamId);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Abbreviation).HasConversion(
                abbrevation => abbrevation.Value,
                value => Abbreviation.Create(value)!
                ).IsRequired();
            builder.Property(t => t.Photo).IsRequired(false);
        }
    }
}
