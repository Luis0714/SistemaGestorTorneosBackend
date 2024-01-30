using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IRoleRepository
    {
        List<Role> GetAll();
        Task<Role> GetById(string roleId);
        Task<Role> Create(Role Role);
        Task<bool> Exits(string roleName);
        Task<bool> Exits(Guid rolId);
        Task<Role> Update(Role Role);
        Task Delete(string roleId);
    }
}
