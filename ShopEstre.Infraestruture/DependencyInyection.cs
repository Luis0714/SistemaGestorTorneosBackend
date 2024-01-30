using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopEstre.Application.Common.Contexts;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;
using ShopEstre.Domain.Interfaces.Sercurity.Authorization;
using ShopEstre.Infraestruture.Persistence.Contexts;
using ShopEstre.Infraestruture.Persistence.Implemetations.Repositories;
using ShopEstre.Infraestruture.Services.Implementations.Security.Authentication;
using ShopEstre.Infraestruture.Services.Implementations.Security.Authorization;
using System.Reflection;

namespace ShopEstre.Infraestruture
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration) {
            AddPersistence(services, configuration);
            AddServices(services);
            return services;
        }

        private static void AddPersistence(IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IApplicationDbContext>(serviceProvider => serviceProvider.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());
            #endregion

            #region Repositories
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPlayerGameRepository, PlayerGameRepository>();
            services.AddScoped<IPlayerGameStatisticsRepository, PlayerGameStatisticsRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IPlayerTeamTournamentsRepository, PlayerTeamTournamentRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ITournamentGameStatisticsRepository, TournamentGameStatisticsRepository>();
            services.AddScoped<ITournamentRepository, TournamentRepository>();
            services.AddScoped<ITournamentStateRepository, TournamentStateRepository>();
            services.AddScoped<ITournamentStatisticsRepository, TournamentStatisticsRepository>();
            services.AddScoped<ITournamentTeamsRepository, TournamentTeamsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddSingleton<IRequestService, RequestService>();
        }
    }
}
