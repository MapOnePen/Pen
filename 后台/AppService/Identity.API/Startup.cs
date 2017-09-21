using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using IdentityServer4.Models;

namespace Identity.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var clients = new List<Client>() {
                new Client(){
                    ClientName ="ZhouServer",
                    ClientSecrets=new List<Secret>(){ new Secret("hsL7J6nACUol1916h1yiPygPhxnGFiwA", null) },
                    ClientId="zhou.test"
                },
            };
            var IdentityResources = new List<IdentityResource>()
            {
                new IdentityResource(){
                    DisplayName="ceshi API",
                    Name="ceshi",
                    Enabled=true
                },
            };
            services.AddIdentityServer()
                .AddInMemoryIdentityResources(IdentityResources)
                .AddInMemoryClients(clients);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseIdentityServer();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
