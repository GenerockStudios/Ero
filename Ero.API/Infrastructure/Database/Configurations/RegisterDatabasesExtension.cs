using Microsoft.EntityFrameworkCore;

namespace Ero.API.Infrastructure.Database.Configurations
{
    public static class RegisterDatabasesExtension
    {
        public static IServiceCollection AddDatabaseEroContext(this IServiceCollection services, IConfiguration configuration)
        {
            string cs = configuration.GetConnectionString("ero_context_postgresql")!;
            services.AddDbContext<EroContext>(options =>
            {
                options.UseNpgsql(cs, c => c.MigrationsAssembly("Ero.API"));
            }
           );
            return services;
        }
    }
}
