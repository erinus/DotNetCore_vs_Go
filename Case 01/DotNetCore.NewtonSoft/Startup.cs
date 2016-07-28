using System;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TestServer
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        	
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            RouteBuilder builder = new RouteBuilder(app);

            builder.MapGet("api/values", new RequestDelegate(delegate (HttpContext ctx)
            {
                ctx.Response.ContentType = "application/json; charset=utf-8";

                string[] data = new string[] { "value1", "value2" };

                string body = JsonConvert.SerializeObject(data);

                return ctx.Response.WriteAsync(body);
            }));

            app.UseRouter(builder.Build());
        }
    }
}
