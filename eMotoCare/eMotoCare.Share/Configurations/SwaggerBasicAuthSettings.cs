namespace eMotoCare.Share.Configurations;

public sealed class SwaggerBasicAuthSettings
{
    public const string SectionName = "SwaggerBasicAuth";

    public string Username { get; init; } = string.Empty;

    public string Password { get; init; } = string.Empty;

    public bool IsConfigured =>
        !string.IsNullOrWhiteSpace(Username)
        && !string.IsNullOrWhiteSpace(Password);
}
