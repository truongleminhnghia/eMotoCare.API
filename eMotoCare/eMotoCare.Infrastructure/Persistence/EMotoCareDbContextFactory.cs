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

        string currentDirectory = Directory.GetCurrentDirectory();
        string basePath = File.Exists(Path.Combine(currentDirectory, "appsettings.json"))
            ? currentDirectory
            : Directory.Exists(Path.Combine(currentDirectory, "eMotoCare.API"))
                ? Path.Combine(currentDirectory, "eMotoCare.API")
                : Path.GetFullPath(Path.Combine(currentDirectory, "..", "eMotoCare.API"));

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        string connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' was not found.");

        DbContextOptionsBuilder<EMotoCareDbContext> optionsBuilder = new();
        optionsBuilder.UseNpgsql(connectionString);

        return new EMotoCareDbContext(optionsBuilder.Options);
    }
}
