using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Progetto_UI.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Environment.SpecialFolder.LocalApplicationData);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(kestrel =>
                    {
                        kestrel.AddServerHeader = false;
                    });

                    webBuilder.UseStartup<Startup>();
                });
    }
}