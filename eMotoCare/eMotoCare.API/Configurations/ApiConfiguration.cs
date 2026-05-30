using eMotoCare.Application;
using eMotoCare.Infrastructure;
using eMotoCare.Share.Configurations;
using Microsoft.Extensions.Options;

namespace eMotoCare.API.Configurations;

public static class ApiConfiguration
{
    public static IServiceCollection AddApiConfiguration(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddControllers();
        services.AddConfigurationModels(configuration);
        services.AddApplication();
        services.AddInfrastructure(configuration);
        services.AddJwtAuthentication(configuration);
        services.AddOpenApi();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerDocumentation();

        return services;
    }

    private static IServiceCollection AddConfigurationModels(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.Configure<SwaggerBasicAuthSettings>(
            configuration.GetSection(SwaggerBasicAuthSettings.SectionName));
        services.AddSingleton(serviceProvider =>
            serviceProvider.GetRequiredService<IOptions<JwtSettings>>().Value);
        services.AddSingleton(serviceProvider =>
            serviceProvider.GetRequiredService<IOptions<SwaggerBasicAuthSettings>>().Value);

        return services;
    }
}
