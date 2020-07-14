using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TradingPlatformTest.Infrastructure;
using TradingPlatformTest.Models;
using TradingPlatformTest.Repositories;

namespace TradingPlatformTest
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
            services.AddDbContext<TradingPlatformContext>(builder => builder.UseSqlServer(Configuration.GetConnectionString("TradingPlatformDBConnectionLocalServer")).UseLazyLoadingProxies());

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<TradingPlatformContext>();

            services.AddControllersWithViews();

            services.AddScoped<IUserRepository, SqlUserRepository>();

            services.AddScoped<IFileService, FileService>();

            services.AddScoped<IItemRepository, SqlItemRepository>();

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    
            app.UseAuthorization();

            app.Use((request, next) =>
            {
                TradingPlatformContext dbContext = request.RequestServices.GetRequiredService<TradingPlatformContext>();

                var country = dbContext.Countries.FirstOrDefault(t => t.Name == "United States");

                City city = new City() { Name="Washington", Country = country };
   
                dbContext.Cities.Add(city);

                dbContext.SaveChanges();

                return next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
