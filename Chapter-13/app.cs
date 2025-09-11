using System.Text.Json;

record Config(string TaskName, DateTime ScheduledAt);

var json = JsonSerializer.Serialize(
    new Config("BackupDatabase", DateTime.Now.AddHours(1)),
    new JsonSerializerOptions { WriteIndented = true }
);

Console.WriteLine($"Scheduled Task:\n{json}");
