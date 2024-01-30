using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class PlayerGameStatisticsRepository : IPlayerGameStatisticsRepository
    {
        private readonly ApplicationDbContext _context;
        public PlayerGameStatisticsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PlayerGameStatistics> Create(PlayerGameStatistics playerGameStatistics)
        {
            var response = await _context.PlayerGameStatistics.AddAsync(playerGameStatistics);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(PlayerGameStatistics PlayerGameStatistics)
        {
            throw new NotImplementedException();
        }

        public List<PlayerGameStatistics> GetAll() => _context.PlayerGameStatistics.ToList();
    }
}
