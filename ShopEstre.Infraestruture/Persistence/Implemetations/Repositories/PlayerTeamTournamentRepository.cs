using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class PlayerTeamTournamentRepository : IPlayerTeamTournamentsRepository
    {
        private readonly ApplicationDbContext _context;
        public PlayerTeamTournamentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PlayerTeamTournaments> Create(PlayerTeamTournaments playerTeamTournaments)
        {
            var response = await _context.PlayerTeamTournaments.AddAsync(playerTeamTournaments);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(PlayerTeamTournaments PlayerTeamTournaments)
        {
            throw new NotImplementedException();
        }

        public List<PlayerTeamTournaments> GetAll() => _context.PlayerTeamTournaments.ToList();
    }
}
