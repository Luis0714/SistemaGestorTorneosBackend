using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class TournamentTeamsRepository : ITournamentTeamsRepository
    {
        private readonly ApplicationDbContext _context;
        public TournamentTeamsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TournamentTeams> Create(TournamentTeams tournamentTeams)
        {
            var response = await _context.TournamentTeams.AddAsync(tournamentTeams);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(TournamentTeams TournamentTeams)
        {
            throw new NotImplementedException();
        }

        public List<TournamentTeams> GetAll() => _context.TournamentTeams.ToList();
    }
}
