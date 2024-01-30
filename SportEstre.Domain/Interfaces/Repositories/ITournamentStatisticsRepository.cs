using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface ITournamentStatisticsRepository
    {
        List<TournamentStatistics> GetAll();
        Task<TournamentStatistics> Create(TournamentStatistics TournamentStatistics);
        Task<bool> Exits(TournamentStatistics TournamentStatistics);
    }
}