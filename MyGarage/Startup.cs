using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using MyGarage.Models;

namespace MyGarage
{
   public class Startup
   {
      //   F i e l d s   &   P r o p e r t i e s

      private IConfiguration _configuration { get; }

      //   C o n s t r u c t o r s

      public Startup(IConfiguration configuration)
      {
         _configuration = configuration;
      }

      //   M e t h o d s

      // This method gets called by the runtime. Use this method to add services to the container.
      // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
      public void ConfigureServices(IServiceCollection services)
      {
         //services.AddDbContext<AppDbContext>(options =>
         //  options.UseSqlServer
         //     (_configuration
         //         .GetConnectionString("DefaultConnection")));

         //services.AddDbContext<AppDbContext>(options =>
         //options.UseSqlServer
         //(_configuration
         //.GetConnectionString("AzureConnection")));

         services.AddDbContext<AppDbContext>(options =>
         options.UseSqlServer
         (System.Environment.GetEnvironmentVariable("mygarageConnectionString")));

         services.AddScoped<IUserRepository, EfUserRepository>();
         services.AddScoped<IVehicleRepository, EfVehicleRepository>();
         services.AddScoped<IRepairRepository, EfRepairRepository>();
         services.AddScoped<IUpgradeRepository, EfUpgradeRepository>();

         services.AddControllersWithViews();

         //Session
         services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
         services.AddDistributedMemoryCache();
         services.AddSession();
      }//End ConfigureServices()

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app.UseDeveloperExceptionPage();
         app.UseStatusCodePages();
         app.UseStaticFiles();

         app.UseRouting();

         app.UseSession();

         app.UseEndpoints(endpoints =>
         {
            //   endpoints.MapGet("/", async context =>
            //      {
            //       await context.Response.WriteAsync("Hello World!");
            //    });
            endpoints.MapDefaultControllerRoute();
         });
      }
   }//End Configure()
}

