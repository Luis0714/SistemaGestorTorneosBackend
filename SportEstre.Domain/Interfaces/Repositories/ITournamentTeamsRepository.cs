using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface ITournamentTeamsRepository
    {
        List<TournamentTeams> GetAll();
        Task<TournamentTeams> Create(TournamentTeams TournamentTeams);
        Task<bool> Exits(TournamentTeams TournamentTeams);
    }
}