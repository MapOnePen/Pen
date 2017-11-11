using Microsoft.AspNetCore.Hosting;

namespace SourcePoint.Service.Identity.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
                new WebHostBuilder()
                .UseStartup<Startup>()
                .UseUrls("http://*:8010")
                .Build();
    }
}
