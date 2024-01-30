using ShopEstre.Domain.Entities;

namespace ShopEstre.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        Task Delete(string id);
        Task<User> GetById(string userId);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<bool> Exits(User user);
        Task<bool> Exits(string userId);
        Task<User> GetByEmail(string email);

    }
}
