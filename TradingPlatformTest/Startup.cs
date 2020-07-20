using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using TradingPlatformTest.Infrastructure;
using TradingPlatformTest.Infrastructure.BackgroundServices.Implementations;
using TradingPlatformTest.Infrastructure.BackgroundServices.Interfaces;
using TradingPlatformTest.Infrastructure.Services.Implementations;
using TradingPlatformTest.Infrastructure.Services.Interfaces;
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

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;
            });

            services.AddControllersWithViews();

            services.AddScoped<IUserRepository, SqlUserRepository>();

            services.AddScoped<IFileService, FileService>();

            services.AddScoped<IItemRepository, SqlItemRepository>();

            services.AddScoped<ICountriesRepository, SqlCountriesRepository>();

            services.AddScoped<ICategoryRepository, SqlCategoryRepository> ();

            services.AddScoped<IServiceRestClient, ServiceRestClient> ();

            services.AddScoped<ISynchroniseCurrencyRate, SynchroniseCurrencyRate> ();

            //services.AddHostedService<SyncCurrencyRateBackgroundService>(); // commented due to API requests limitations


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

            //app.Use((request, next) =>
            //{
            //    TradingPlatformContext dbContext = request.RequestServices.GetRequiredService<TradingPlatformContext>();
            //    var countries = new CurrencyRate();
            //    using (StreamReader r = new StreamReader(@"C:\temp\currencyrate.json"))
            //    {
            //        string json = r.ReadToEnd();
            //        countries = JsonConvert.DeserializeObject<CurrencyRate>(json);
            //    }

               
            //        dbContext.CurrencyRate.Add(countries);
                

            //    dbContext.SaveChanges();

            //    return next();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
