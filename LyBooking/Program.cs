using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using LyBooking.Helpers;
using System.Linq;
using System.Net;

namespace LyBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
