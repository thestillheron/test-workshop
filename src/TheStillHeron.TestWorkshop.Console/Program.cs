using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheStillHeron.TestWorkshop.Console.FamilyPlanning;
using TheStillHeron.TestWorkshop.Console.Weather;

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

            var apiClient = new WeatherApiClient(config);
            var engine = new RecommendationEngine(apiClient);
            System.Console.WriteLine(await engine.GetRecommendation());

            var dateProvider = new FamilyPlanningDateProvider();
            var familyPlanner = FamilyPlanner.Basic();
            System.Console.WriteLine(familyPlanner.DayPlan(dateProvider));

            // end exercise 2

            await host.RunAsync();
        }
    }
}
