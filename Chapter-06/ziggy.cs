// Top-level statements
Console.WriteLine("Hello from Ziggy Rafiq!");

// Primary constructors simulated with regular properties
class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Deconstruct(out string n, out int a) => (n, a) = (Name, Age);
}

// List patterns
int[] arr = { 1, 2, 3, 4, 5 };
if (arr is [1, 2, .. var rest])
{
    Console.WriteLine($"Rest of the list: {string.Join(',', rest)}");
}

// Static helper class
static class Helper
{
    public static void Greet(string name) => Console.WriteLine($"Hi, {name}! from Ziggy Rafiq");
}

Helper.Greet("Ziggy");

// Required members (ignored in script, no enforcement)
class Employee
{
    public required string Name { get; set; }
}

// Interpolated string handlers
int x = 45;
Console.WriteLine($"Value: {x}");

// Lambda improvements with delegate specified
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

// nameof() usage
var p = new Person("Ziggy", 45);
Console.WriteLine(nameof(p.Name));
