using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;
        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Game> Create(Game Game)
        {
            var response = await _context.Games.AddAsync(Game);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(Game Game) =>
            _context.Games.AnyAsync(GameSaved => GameSaved.LocalTeam.Name == Game.LocalTeam.Name &&
            GameSaved.VisitingTeam.Name == Game.VisitingTeam.Name);

        public List<Game> GetAll() => _context.Games.ToList();
    }
}
