using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace BooksAPISample
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
            // services.AddSwaggerGen();
            services.AddSwaggerGen(options =>
            {
                // options.IncludeXmlComments("../docs/BooksServiceSample.xml");
                options.SwaggerDoc("v1", new Info
                {
                    Title = "Books Service API",
                    Version = "v1",
                    Description = "Sample service for a workshop",
                    Contact = new Contact { Name = "Christian Nagel", Url = "https://csharp.christiannagel.com" },
                    License = new License { Name = "MIT License" }
                });
            });
            services.AddDbContext<RazorBooksContext>(options =>
            {
                string booksConnection = Configuration.GetConnectionString("BooksConnection");
                options.UseSqlServer(booksConnection);
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options =>
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Book Services"));

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
