using Microsoft.EntityFrameworkCore;
using ShopEstre.Domain.Entities;


namespace ShopEstre.Application.Common.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Role> Rols { get; }
        DbSet<Tournament> Tournaments { get; }
        DbSet<Game> Games { get; }
        DbSet<Player> Players { get; }
        DbSet<Team> Teams { get; }
    }
}
