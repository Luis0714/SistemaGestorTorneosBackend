using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class TournamentRepository : ITournamentRepository
    {
        private readonly ApplicationDbContext _context;
        public TournamentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Tournament> Create(Tournament Tournament)
        {
            var response = await _context.Tournaments.AddAsync(Tournament);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(Tournament Tournament) => _context.Tournaments.AnyAsync(TournamentSaved => TournamentSaved.Name == Tournament.Name);

        public List<Tournament> GetAll() => _context.Tournaments.ToList();

    }
}
