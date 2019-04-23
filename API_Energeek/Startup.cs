using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Energeek.Models;
using API_Energeek.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API_Energeek
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
            var connectionString ="Server=localhost;Database=energeekDB;User Id=sa;Password=Passw0rd!";
            services
              .AddDbContext<MyDbContext>(o =>
                o.UseSqlServer(connectionString));

            services.AddMvc();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserProductRepository, UserProductRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MyDbContext myDbContext)
        {
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();*/


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            myDbContext.CreateSeedData();
            myDbContext.CreateUserData();

            app.UseHttpsRedirection();
            app.UseMvc();

            app.Run(async (context) =>
            {
                await context
                       .Response
                       .WriteAsync("Hello World!");
            });



        }
    }
}
