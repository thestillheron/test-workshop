using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TheStillHeron.TestWorkshop.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        static async Task Run()
        {
            using IHost host = Host.CreateDefaultBuilder()
                .UseEnvironment(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"))
                .Build();
            var config = host.Services.GetRequiredService<IConfiguration>();
            var engine = new RecommendationEngine(config);
            System.Console.WriteLine(await engine.GetRecommendation());

            await host.RunAsync();
        }
    }
}
