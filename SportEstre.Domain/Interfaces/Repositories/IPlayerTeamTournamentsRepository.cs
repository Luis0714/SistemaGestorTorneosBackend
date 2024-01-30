using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IPlayerTeamTournamentsRepository
    {
        List<PlayerTeamTournaments> GetAll();
        Task<PlayerTeamTournaments> Create(PlayerTeamTournaments PlayerTeamTournaments);
        Task<bool> Exits(PlayerTeamTournaments PlayerTeamTournaments);
    }
}