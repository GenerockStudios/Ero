using Microsoft.EntityFrameworkCore;

namespace Ero.API.Infrastructure.Database.Initializers
{
    public static class InitializeEroContextExtension
    {
        /// <summary>
        /// This extension Initialize Ero database
        /// </summary>
        /// <param name="serviceProvider">Service provider of scope, of your application</param>
        /// <returns></returns>
        public async static Task<IServiceProvider> InitializeEroContext(this IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<EroContext>();
            await context.Database.MigrateAsync();
            return serviceProvider;
        }
    }
}
