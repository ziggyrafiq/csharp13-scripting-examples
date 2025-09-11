class Person(string name, int age)
{
public void Introduce() => Console.WriteLine($"I'm {name}, {age} years old.");
}


int[] numbers = [1, 2, 3, 4, 5];
if (numbers is [1, 2, .. var rest])
{
Console.WriteLine($"Rest: {string.Join(",", rest)}");
}


var p = new Person("Ziggy", 45);
p.Introduce();
