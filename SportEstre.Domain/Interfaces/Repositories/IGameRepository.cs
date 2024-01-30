using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IGameRepository
    {
        List<Game> GetAll();
        Task<Game> Create(Game Game);
        Task<bool> Exits(Game Game);
    }
}
