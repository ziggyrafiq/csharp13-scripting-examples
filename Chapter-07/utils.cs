static class Utils
{
    public static void Greet(string name) =>
        Console.WriteLine($"Hello, from Ziggy Rafiq {name}!");
}

//In your main app.cs file, call the helper method as follows:

Utils.Greet("Ziggy");
