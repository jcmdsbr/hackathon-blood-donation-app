using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarCastGrupoDois.Infra.CrossCutting.Identity;
using StarCastGrupoDois.Infra.CrossCutting.Identity.Models;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGroupDois.UI.Site.Configurations
{
    public static class ServiceExtensions
    {
        public static void AddMvcWithCustomJson(this IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });
        }

        public static void AddStarCastGroupoDoisContexto(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StarCastGroupoDoisContexto>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureIdentityOptions(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 0;
            });
        }

        public static void AddIdentityContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityContexto>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContexto>()
                .AddDefaultTokenProviders();
        }
    }
}