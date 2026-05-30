namespace eMotoCare.Share.Configurations;

public static class EnvironmentConfiguration
{
    public static void LoadLocalEnvironmentVariables(string? environmentName = null)
    {
        if (!string.Equals(environmentName, "Development", StringComparison.OrdinalIgnoreCase)
            && !string.IsNullOrWhiteSpace(environmentName))
        {
            return;
        }

        string? envPath = FindEnvironmentFile();
        if (envPath is null)
        {
            return;
        }

        foreach (string rawLine in File.ReadAllLines(envPath))
        {
            string line = rawLine.Trim();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith('#'))
            {
                continue;
            }

            int separatorIndex = line.IndexOf('=');
            if (separatorIndex <= 0)
            {
                continue;
            }

            string key = line[..separatorIndex].Trim();
            string value = line[(separatorIndex + 1)..].Trim().Trim('"');

            if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable(key)))
            {
                Environment.SetEnvironmentVariable(key, value);
            }
        }
    }

    private static string? FindEnvironmentFile()
    {
        DirectoryInfo? directory = new(AppContext.BaseDirectory);

        while (directory is not null)
        {
            string envPath = Path.Combine(directory.FullName, ".env");
            if (File.Exists(envPath))
            {
                return envPath;
            }

            directory = directory.Parent;
        }

        return null;
    }
}
