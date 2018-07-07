using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarCastGroupDois.UI.Site.Configurations;
using StarCastGrupoDois.Infra.CrossCutting.IoC;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGroupDois.UI.Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddStarCastGroupoDoisContexto(Configuration);

            //Todo=> implementar Identity

            //services.AddIdentityContext(Configuration);

            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.Cookie.Name = "StarCast";
            //    options.LoginPath = "/Login/Login";
            //});

            //services.ConfigureIdentityOptions();

            services.AddMvcWithCustomJson();

            services.AddResponseCaching();

            NativeInjectorBootstrapper.RegisterServices(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseResponseCaching();
            app.UseMvcWithDefaultRoute();
        }
    }
}
