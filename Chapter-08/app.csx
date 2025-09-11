#r "nuget: Newtonsoft.Json, 13.0.3"
using Newtonsoft.Json;

var obj = new { Name = "Ziggy", Age = 45 };
Console.WriteLine(JsonConvert.SerializeObject(obj));
