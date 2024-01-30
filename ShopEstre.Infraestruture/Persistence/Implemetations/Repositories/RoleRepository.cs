using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.Infraestruture.Persistence.Implemetations.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Role> Create(Role role)
        {
            var response = await _context.Rols.AddAsync(role);
            await _context.SaveChangesAsync();
            return response.Entity;
        }

        public async Task Delete(string roleId)
        {
            var role = await GetById(roleId);
            var response = _context.Rols.Remove(role);
            await _context.SaveChangesAsync();
        }

        public Task<bool> Exits(string roleName) => _context.Rols.AnyAsync(rol => rol.Name.Equals(roleName));

        public Task<bool> Exits(Guid rolId) => _context.Rols.AnyAsync(rol => rol.RolId == rolId);

        public List<Role> GetAll() => _context.Rols.ToList();

        public  Task<Role> GetById(string roleId) => _context.Rols.FirstOrDefaultAsync(role => role.RolId == new Guid(roleId))!;

        public async Task<Role> Update(Role role)
        {
            var response = _context.Entry(role).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return role;
        }
    }
}
