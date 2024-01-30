using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _context;
        public TeamRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Team> Create(Team team)
        {
            var response = await _context.AddAsync(team);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public Task<bool> Exits(Team Team) => _context.Teams.AnyAsync(Teamsaved => Teamsaved.Name == Team.Name);

        public List<Team> GetAll() => _context.Teams.ToList();
    }
}
