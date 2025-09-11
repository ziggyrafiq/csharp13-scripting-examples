try
{
    var config = Config.Load();

    if (config.LoggingEnabled)
        Console.WriteLine("Logging is enabled.");

    var obj = new { Name = "Ziggy", Age = 45, ApiKeyUsed = config.ApiKey };

    string json = JsonService.Serialize(obj);
    Console.WriteLine("Serialized output:");
    Console.WriteLine(json);

    return 0; // success
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Error: {ex.Message}");
    return 1; // error code
}
