using Blazored.SessionStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_ERP_System.Data;
using Blazored.Toast;
using Blazored.Toast.Services;
using TOCOMA_ERP_ClassLibrary.Models;


namespace TOCOMA_ERP_System
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();            
            services.AddScoped<ProtectedSessionStorage>();
            services.AddBlazoredSessionStorage();
            services.AddHttpClient();
            services.AddScoped<ToastService>();
            services.AddBlazoredToast();
            services.AddScoped<SessionData>();
            services.AddScoped<SessionState>();
            services.AddProtectedBrowserStorage();
            services.AddScoped<PlanAndWorkScheduleService>();

           Utility.BaseUrl = "https://localhost:44382/";    /// API URL Local
           //Utility.BaseUrl = "https://103.169.100.126:8040/";    /// API URL Local
            //Utility.BaseUrl = "http://localhost:8040/";    /// API URL
            //Utility.BaseUrl = "http://erp-api.baburchisheba.com/";    /// API URL
           //Utility.BaseUrl = "http://103.169.100.126:8040/";    /// API URL

            
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
