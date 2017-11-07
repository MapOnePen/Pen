using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            AddSingleHost(new WebHostBuilder()) // 不能使用 WebHost.CreateDefaultBuilder(args) 进行创建 后面获取注入时会报错
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .UseUrls("http://*:8088")
            .Build();

        private static IWebHostBuilder AddSingleHost(IWebHostBuilder webHost) =>
            webHost.ConfigureServices(x => x.AddSingleton(webHost));
    }

}
