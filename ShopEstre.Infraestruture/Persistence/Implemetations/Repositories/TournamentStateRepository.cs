using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class TournamentStateRepository : ITournamentStateRepository
    {
        private readonly ApplicationDbContext _context;
        public TournamentStateRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TournamentState> Create(TournamentState tournamentState)
        {
            var response = await _context.TournamentStates.AddAsync(tournamentState);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(TournamentState TournamentState)
        {
            throw new NotImplementedException();
        }

        public List<TournamentState> GetAll() => _context.TournamentStates.ToList();
    }  
}
