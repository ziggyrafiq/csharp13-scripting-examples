var apiKey = Environment.GetEnvironmentVariable("API_KEY");

Console.WriteLine(string.IsNullOrWhiteSpace(apiKey) ? "The API_KEY not found. Please set it before running the script." : $"We are Using API Key: {apiKey}");
