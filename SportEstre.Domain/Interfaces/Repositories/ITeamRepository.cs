using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface ITeamRepository
    {
        List<Team> GetAll();
        Task<Team> Create(Team Team);
        Task<bool> Exits(Team Team);
    }
}
