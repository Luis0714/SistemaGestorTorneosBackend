using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IPlayerGameRepository
    {
        List<PlayerGame> GetAll();
        Task<PlayerGame> Create(PlayerGame Game);
        Task<bool> Exits(PlayerGame Game);
    }
}
