using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class TournamentGameStatisticsRepository : ITournamentGameStatisticsRepository
    {
        private readonly ApplicationDbContext _context;
        public TournamentGameStatisticsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TournamentGameStatistics> Create(TournamentGameStatistics tournamentGameStatistics)
        {
            var response = await _context.TournamentGameStatistics.AddAsync(tournamentGameStatistics);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(TournamentGameStatistics TournamentGameStatistics)
        {
            throw new NotImplementedException();
        }

        public List<TournamentGameStatistics> GetAll() => _context.TournamentGameStatistics.ToList();
    }
}
