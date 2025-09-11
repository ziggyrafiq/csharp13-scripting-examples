// app.cs
 // Primary Constructor in class (C# 13 feature)
class Person(string name, int age)
{
    public void Introduce() => Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
}

// Create an instance and call a method
var p = new Person("Ziggy", 45);
p.Introduce();


// List Pattern Matching (C# 13 enhancement)
int[] numbers = [1, 2, 3, 4, 5];

// Match the list pattern and capture remaining values
if (numbers is [1, 2, .. var rest])
{
    Console.WriteLine($"Rest of the list: {string.Join(",", rest)}");
}
