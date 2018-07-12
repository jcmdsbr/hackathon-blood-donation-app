using Microsoft.Extensions.DependencyInjection;
using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Infra.Repository.Context;
using StarCastGrupoDois.Infra.Repository.Repository;
using StarCastGrupoDois.Infra.Repository.UoW;

namespace StarCastGrupoDois.Infra.CrossCutting.IoC
{
    internal class RepositoryDependencyResolver
    {
        internal static void Register(IServiceCollection services)
        {
            services.AddScoped<IAlertaRepositorio, AlertaRepositorio>();

            services.AddScoped<IDoacaoRepositorio, DoacaoRepositorio>();

            services.AddScoped<IDoadorRepositorio, DoadorRepositorio>();

            services.AddScoped<IParceiroRepositorio, ParceiroRepositorio>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<StarCastGroupoDoisContexto>();
        }
    }
}