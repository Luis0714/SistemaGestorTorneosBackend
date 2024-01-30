using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAll();
        Task<Player> Create(Player Player);
        Task<bool> Exits(Player Player);
    }
}
