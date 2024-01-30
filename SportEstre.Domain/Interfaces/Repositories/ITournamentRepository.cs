using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface ITournamentRepository
    {
        List<Tournament> GetAll();
        Task<Tournament> Create(Tournament Tournament);
        Task<bool> Exits(Tournament Tournament);
    }
}
