using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> Create(User user) {
            var response = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public async Task<User> Update(User user)
        {
            var response = _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }
        public Task<bool> Exits(User user) => _context.Users.AnyAsync(userSaved => userSaved.Email == user.Email);

        public List<User> GetAll() => _context.Users.Include(user => user.Role).ToList();

        public Task<User> GetByEmail(string email) => _context.Users.FirstOrDefaultAsync(user => user.Email == email)!;
        public Task<User> GetById(string userId) => _context.Users.FirstOrDefaultAsync(user => user.UserId == new Guid(userId))!;

        public async Task Delete(string id) {
            var user =await GetById(id);
            var response = _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public Task<bool> Exits(string userId) => _context.Users.Include(user => user.Role).AnyAsync(user => user.UserId == new Guid(userId));
    }
}
