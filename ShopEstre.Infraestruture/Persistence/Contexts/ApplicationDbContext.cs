using Microsoft.EntityFrameworkCore;
using ShopEstre.Application.Common.Contexts;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Infraestruture.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext, IUnitOfWork
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerGame> PlayersGame { get; set; }
        public DbSet<PlayerGameStatistics> PlayerGameStatistics { get; set; }
        public DbSet<PlayerTeamTournaments> PlayerTeamTournaments { get; set; }
        public DbSet<Role> Rols { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentGameStatistics> TournamentGameStatistics { get; set; }
        public DbSet<TournamentState> TournamentStates { get; set; }
        public DbSet<TournamentStatistics> TournamentStatistics { get; set; }
        public DbSet<TournamentTeams> TournamentTeams { get; set; }
        public DbSet<User> Users { get; set; }
    
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) =>
            await base.SaveChangesAsync(cancellationToken);
            
    }
}
