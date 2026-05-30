using System.Net;
using System.Text;
using eMotoCare.Share.Configurations;

namespace eMotoCare.API.Configurations;

public static class SwaggerBasicAuthMiddleware
{
    public static IApplicationBuilder UseSwaggerBasicAuthentication(this IApplicationBuilder app)
    {
        return app.Use(async (context, next) =>
        {
            if (!IsSwaggerRequest(context.Request))
            {
                await next();
                return;
            }
            SwaggerBasicAuthSettings settings = context.RequestServices
                .GetRequiredService<SwaggerBasicAuthSettings>();
            if (!settings.IsConfigured || IsAuthorized(context.Request, settings))
            {
                await next();
                return;
            }
            context.Response.Headers.WWWAuthenticate = "Basic realm=\"eMotoCare Swagger\"";
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        });
    }

    private static bool IsSwaggerRequest(HttpRequest request)
    {
        return request.Path.StartsWithSegments("/swagger")
            || request.Path.StartsWithSegments("/openapi");
    }

    private static bool IsAuthorized(HttpRequest request, SwaggerBasicAuthSettings settings)
    {
        string? authorization = request.Headers.Authorization;
        if (string.IsNullOrWhiteSpace(authorization)
            || !authorization.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
        string encodedCredentials = authorization["Basic ".Length..].Trim();
        string decodedCredentials;
        try
        {
            byte[] bytes = Convert.FromBase64String(encodedCredentials);
            decodedCredentials = Encoding.UTF8.GetString(bytes);
        }
        catch (FormatException)
        {
            return false;
        }
        string expectedCredentials = $"{settings.Username}:{settings.Password}";
        return WebUtility.UrlDecode(decodedCredentials) == expectedCredentials;
    }
}
