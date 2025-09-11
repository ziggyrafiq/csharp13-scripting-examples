using System.Text.Json;

public class Config
{
    public string ApiKey { get; set; } = string.Empty;
    public bool LoggingEnabled { get; set; }

    public static Config Load(string path = "appsettings.json") =>
        JsonSerializer.Deserialize<Config>(
            File.ReadAllText(path)
        ) ?? throw new InvalidDataException("Invalid or empty configuration file.");
}
