using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SystemLoggerAPI.Brokers.Storage
{
    public class StorageBroker : EFxceptions.EFxceptionsContext , IStorageBroker
    {
        private readonly IConfiguration _configuration;
        public StorageBroker(IConfiguration configuration)
        {
            _configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);            
        }
    }
}
