using Microsoft.EntityFrameworkCore;

namespace Ero.API.Infrastructure.Database
{
    public class EroContext: DbContext
    {
        public EroContext(DbContextOptions<EroContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Base call  
            base.OnModelCreating(builder);
        }
    }
}
