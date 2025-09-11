using System.Text.Json;

public static class JsonService
{
    public static string Serialize(object obj) =>
        JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
}
