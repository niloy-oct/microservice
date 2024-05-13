using MongoRepo.Context;

namespace Catalog.API.DatabaseContext
{
    public class CatalogDbContext : ApplicationDbContext
    {
        static readonly IConfiguration Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
        static readonly string? ConnectionString = Configuration.GetConnectionString("Catalog.API");
        static readonly string? DatabaseName = Configuration.GetValue<string>("DatabaseName");
        public CatalogDbContext() : base(ConnectionString, DatabaseName)
        {

        }
    }
}
