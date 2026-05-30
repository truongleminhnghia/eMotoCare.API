using eMotoCare.Share.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace eMotoCare.API.Configurations;

public static class AuthenticationConfiguration
{
    public static IServiceCollection AddJwtAuthentication(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        JwtSettings jwtSettings = configuration
            .GetSection(JwtSettings.SectionName)
            .Get<JwtSettings>() ?? new JwtSettings();

        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = true;
                options.SaveToken = true;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = !string.IsNullOrWhiteSpace(jwtSettings.Issuer),
                    ValidIssuer = jwtSettings.Issuer,
                    ValidateAudience = !string.IsNullOrWhiteSpace(jwtSettings.Audience),
                    ValidAudience = jwtSettings.Audience,
                    ValidateIssuerSigningKey = !string.IsNullOrWhiteSpace(jwtSettings.SigningKey),
                    IssuerSigningKey = string.IsNullOrWhiteSpace(jwtSettings.SigningKey)
                        ? null
                        : new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtSettings.SigningKey)),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(2)
                };
            });

        services.AddAuthorization();

        return services;
    }
}
