// Program.cs

using Newtonsoft.Json;

var obj = new { Name = "Ziggy", Age = 45 };
var json = JsonConvert.SerializeObject(obj);
Console.WriteLine(json);
