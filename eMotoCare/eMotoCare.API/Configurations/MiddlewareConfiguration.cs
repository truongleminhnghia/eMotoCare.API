namespace eMotoCare.API.Configurations;

public static class MiddlewareConfiguration
{
    public static WebApplication UseApiConfiguration(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwaggerBasicAuthentication();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();

        return app;
    }
}
