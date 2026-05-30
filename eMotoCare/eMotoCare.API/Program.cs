using eMotoCare.API.Configurations;
using eMotoCare.Share.Configurations;

EnvironmentConfiguration.LoadLocalEnvironmentVariables(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration(builder.Configuration);

var app = builder.Build();

app.UseApiConfiguration();

app.Run();
