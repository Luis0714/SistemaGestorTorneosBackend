using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface ITournamentGameStatisticsRepository
    {
        List<TournamentGameStatistics> GetAll();
        Task<TournamentGameStatistics> Create(TournamentGameStatistics TournamentGameStatistics);
        Task<bool> Exits(TournamentGameStatistics TournamentGameStatistics);
    }
}