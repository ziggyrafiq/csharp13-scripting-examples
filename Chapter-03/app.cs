// Primary constructor in class
class User(string username, int level)
{
    public void Display() => Console.WriteLine($"User: {username} | Level: {level}");
}

// Regular static helper class
static class Helpers
{
    public static void Greet() => Console.WriteLine("Welcome to C# 13 scripting by Ziggy Rafiq!");
}

// Use modern features
Helpers.Greet();

var user = new User("Ziggy", 45);

user.Display();
