using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class TournamentStatisticsRepository : ITournamentStatisticsRepository
    {
        private readonly ApplicationDbContext _context;
        public TournamentStatisticsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TournamentStatistics> Create(TournamentStatistics tournamentStatistics)
        {
            var response = await _context.TournamentStatistics.AddAsync(tournamentStatistics);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(TournamentStatistics TournamentStatistics)
        {
            throw new NotImplementedException();
        }

        public List<TournamentStatistics> GetAll() => _context.TournamentStatistics.ToList();
    }
}
