using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _context;
        public PlayerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Player> Create(Player Player)
        {
            var response = await _context.Players.AddAsync(Player);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(Player Player) => _context.Players.AnyAsync(PlayerSaved => PlayerSaved.Number == Player.Number);

        public List<Player> GetAll() => _context.Players.ToList();
    }
}
