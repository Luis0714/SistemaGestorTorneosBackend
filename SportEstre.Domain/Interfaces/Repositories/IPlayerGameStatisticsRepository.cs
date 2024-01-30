using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IPlayerGameStatisticsRepository
    {
        List<PlayerGameStatistics> GetAll();
        Task<PlayerGameStatistics> Create(PlayerGameStatistics PlayerGameStatistics);
        Task<bool> Exits(PlayerGameStatistics PlayerGameStatistics);
    }
}
