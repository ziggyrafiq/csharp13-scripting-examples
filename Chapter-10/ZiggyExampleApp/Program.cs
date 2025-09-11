using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<ZiggyService>();
    })
    .Build();

var service = host.Services.GetRequiredService<ZiggyService>();
service.Run();
