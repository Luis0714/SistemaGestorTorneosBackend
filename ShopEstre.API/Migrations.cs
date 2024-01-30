using Microsoft.EntityFrameworkCore;
using ShopEstre.API.Middlewares;
using ShopEstre.Infraestruture.Persistence.Contexts;

namespace ShopEstre.API
{
    public static class Migrations
    {
        public static void ApplyMigrations(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            dbContext.Database.Migrate();
        }
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
