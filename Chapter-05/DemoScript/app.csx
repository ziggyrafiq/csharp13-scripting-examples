// app.cs
#r "nuget: Newtonsoft.Json, 13.0.3"
using Newtonsoft.Json;

var obj = new { Name = "Ziggy", Age = 45 };
var json = JsonConvert.SerializeObject(obj);
Console.WriteLine(json);
