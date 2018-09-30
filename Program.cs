using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FilmClub.Services.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Services
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var jj = BuildWebHost
            CreateWebHostBuilder(args)
            .Build()
            .Run();
            // var host = CreateWebHostBuilder(args).Build();
            // try
            // {
            //     var context = host.Services.GetRequiredService<FilmClubContext>();
            //     DbInitializer.Initialize(context);
            // }
            // catch (Exception ex)
            // {
            //     var logger = host.Services.GetRequiredService<ILogger<Program>>();
            //     logger.LogError(ex, "An error occurred while seeding the database.");
            // }

            // host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
