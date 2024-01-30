using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface ITournamentStateRepository
    {
        List<TournamentState> GetAll();
        Task<TournamentState> Create(TournamentState TournamentState);
        Task<bool> Exits(TournamentState TournamentState);
    }
}