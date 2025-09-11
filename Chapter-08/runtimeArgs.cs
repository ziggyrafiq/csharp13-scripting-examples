// runtimeArgs.cs
Console.WriteLine(Args.Count == 0
    ? "Usage: dotnet script runtimeArgs.cs <API_KEY>"
    : $"Using API Key: {Args[0]}");
