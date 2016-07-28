using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
	            List<Int32> l = new List<Int32>();
	            
	            Random r = new Random();
	            
	            for (int i = 0; i < 1000; i++)
	            {
	                l.Add(r.Next());
	            }
	            
                ctx.Response.ContentType = "application/json; charset=utf-8";

                string[] data = new string[] { "value1", "value2" };

                string body = string.Empty;

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(string[]));

                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.WriteObject(stream, data);

                    body = Encoding.UTF8.GetString(stream.ToArray());
                }

                return ctx.Response.WriteAsync(body);
            }));

            app.UseRouter(builder.Build());
        }
    }
}
