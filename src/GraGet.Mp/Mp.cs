using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using ConsoleAppFramework;

namespace GraGet.Mp
{
    class Mp : ConsoleAppBase
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder().RunConsoleAppFrameworkAsync<Mp>(args);
        }

        [Command("install", "Install package.")]
        public async Task Install([Option(0, "package id")] string[] packageIdList)
        {
            foreach(var packageId in packageIdList)
            {
                Console.WriteLine($"Searching {packageId}... Done");
                Console.WriteLine($"Downloading depend packages... Done");
                Console.WriteLine($"Downloading {packageId}... Done");
                Console.WriteLine($"Installing {packageId}...");

                var dummySec = 3;
                while (dummySec != 0)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1), Context.CancellationToken);
                    dummySec--;
                    Console.WriteLine(".");
                }
            }
        }

        [Command("search", "Search package.")]
        public async Task Search([Option(0, "package id")] string packageId)
        {
            Console.WriteLine($"Searching {packageId}...");

            var hits = new[] { "package C", "package B", "package A" };

            var dummySec = hits.Length;
            while (dummySec != 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(1), Context.CancellationToken);
                dummySec--;
                Console.WriteLine($"{hits[dummySec]}");
            }
        }

        [Command("show", "Show package infomation.")]
        public async Task Show([Option(0, "package id")] string packageId)
        {
            var dummySec = 2;
            while (dummySec != 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(1), Context.CancellationToken);
                dummySec--;
            }

            Console.WriteLine($"Package: {packageId}");
            Console.WriteLine("Version: 1.0.0");
            Console.WriteLine("License: GPL v3");
            Console.WriteLine("Author: John Doe");
            Console.WriteLine("Homepage: https://www.example.com");
        }
    }
}
