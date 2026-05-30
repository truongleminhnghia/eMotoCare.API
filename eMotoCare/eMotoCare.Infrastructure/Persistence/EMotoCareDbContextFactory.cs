using eMotoCare.Share.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eMotoCare.Infrastructure.Persistence;

public class EMotoCareDbContextFactory : IDesignTimeDbContextFactory<EMotoCareDbContext>
{
    public EMotoCareDbContext CreateDbContext(string[] args)
    {
        EnvironmentConfiguration.LoadLocalEnvironmentVariables("Development");

        string basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "eMotoCare.API"));

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        string connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' was not found.");

        DbContextOptionsBuilder<EMotoCareDbContext> optionsBuilder = new();
        optionsBuilder.UseSqlServer(connectionString);

        return new EMotoCareDbContext(optionsBuilder.Options);
    }
}
