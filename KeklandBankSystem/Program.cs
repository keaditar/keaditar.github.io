using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using KeklandBankSystem.Infrastructure;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KeklandBankSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureLogging((context, logger) =>
                    {
                        logger.AddConsole();
                        logger.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Error);
                        logger.AddFilter("Microsoft.EntityFrameworkCore.Query", LogLevel.Error);

                    }).UseStartup<Startup>()
                    .UseUrls(Environment.GetEnvironmentVariable("API_UseUrls") ?? "http://+:5001");
                }).Build().Run();
        }
    }
}
