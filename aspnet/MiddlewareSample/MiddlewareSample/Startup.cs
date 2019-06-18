using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MiddlewareSample.Middleware;

namespace MiddlewareSample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMyCustomMiddleware();

            app.MapWhen(context =>
            {
                return context.Request.Path.Value.Contains("sample2");
            }, builder =>
            {
                builder.Run(async context =>
                {
                    await context.Response.WriteAsync("this is from mapwhen");
                });
            });

            app.Map("/sample1", builder =>
            {
                builder.Run(async context =>
                {
                    await context.Response.WriteAsync("this is from sample 1");
                });
            });

            app.UseStaticFiles();



            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>Hello World!</h1>");
            });
        }
    }
}
