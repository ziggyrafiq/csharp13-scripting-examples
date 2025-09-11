#r "nuget: Newtonsoft.Json, 13.0.3"
using Newtonsoft.Json;
var person = new { Name = "Ziggy Rafiq", Age = 45 };

Console.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));
