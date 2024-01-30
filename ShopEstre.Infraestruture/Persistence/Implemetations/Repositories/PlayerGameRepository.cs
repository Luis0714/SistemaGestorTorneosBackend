using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class PlayerGameRepository : IPlayerGameRepository
    {
        private readonly ApplicationDbContext _context;
        public PlayerGameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PlayerGame> Create(PlayerGame playerGame)
        {
            var response = await _context.PlayersGame.AddAsync(playerGame);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(PlayerGame Game)
        {
            throw new NotImplementedException();
        }

        public List<PlayerGame> GetAll() => _context.PlayersGame.ToList();
    }
}
