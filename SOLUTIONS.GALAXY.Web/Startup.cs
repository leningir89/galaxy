using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOLUTIONS.GALAXY.Application.App;
using SOLUTIONS.GALAXY.Application.Interfaces;
using SOLUTIONS.GALAXY.Data.Repositories.Repositories;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;
using SOLUTIONS.GALAXY.Infraestructure.Repository;
using SOLUTIONS.GALAXY.Infraestructure.Repository.Base;
using SOLUTIONS.GALAXY.Services.Services;

namespace SOLUTIONS.GALAXY.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IJediService, JediService>();
            services.AddScoped<IJediApp, JediApp>();
            services.AddScoped<IJediRepository, JediRepository>();

            services.AddScoped<IHologramService, HologramService>();
            services.AddScoped<IHologramsApp, HologramsApp>();
            services.AddScoped<IHologramRepository, HologramRepository>();

            services.AddScoped<IOrderHologramsService, OrderHologramsService>();
            services.AddScoped<IOrderHologramsApp, OrderHologramsApp>();
            services.AddScoped<IOrdersHologramsRepository, OrdersHologramsRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            Configurations.ConnectionString = Configuration["ConnectionString"];
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
