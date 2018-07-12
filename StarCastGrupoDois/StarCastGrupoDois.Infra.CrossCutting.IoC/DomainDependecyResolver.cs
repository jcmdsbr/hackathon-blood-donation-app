using Microsoft.Extensions.DependencyInjection;
using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Domain.Services;
using StarCastGrupoDois.Infra.Repository.Repository;

namespace StarCastGrupoDois.Infra.CrossCutting.IoC
{
    internal class DomainDependecyResolver
    {
        internal static void Register(IServiceCollection services)
        {
            services.AddScoped<IAlertaQuery, AlertaRepositorio>();
            services.AddScoped<IAlertaService, AlertaService>();

            services.AddScoped<IEnvioEmailService, EnvioEmailService>();

            services.AddScoped<IDoacaoQuery, DoacaoRepositorio>();
            services.AddScoped<IDoacaoService, DoacaoService>();

            services.AddScoped<IDoadorQuery, DoadorRepositorio>();
            services.AddScoped<IDoadorService, DoadorService>();

            services.AddScoped<IParceiroQuery, ParceiroRepositorio>();
            services.AddScoped<IParceiroService, ParceiroService>();
        }
    }
}