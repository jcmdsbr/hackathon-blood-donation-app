using System;
using Microsoft.Extensions.DependencyInjection;
using StarCastGrupoDois.Application.Domain.Alerta;
using StarCastGrupoDois.Application.Domain.Doacao;
using StarCastGrupoDois.Application.Domain.Doador;
using StarCastGrupoDois.Application.Domain.Parceiro;
using StarCastGrupoDois.Domain.Alerta;
using StarCastGrupoDois.Domain.Doacao;
using StarCastGrupoDois.Domain.Doador;
using StarCastGrupoDois.Domain.Parceiro;
using StarCastGrupoDois.Infra.Repository.Repository;

namespace StarCastGrupoDois.Infra.CrossCutting.IoC
{
    internal class DomainDependecyResolver
    {
        internal static void Register(IServiceCollection services)
        {
            services.AddScoped<IAlertaQuery, AlertaRepositorio>();
            services.AddScoped<IAlertaService, AlertaService>();

            services.AddScoped<IDoacaoQuery, DoacaoRepositorio>();
            services.AddScoped<IDoacaoService, DoacaoService>();

            services.AddScoped<IDoadorQuery, DoadorRepositorio>();
            services.AddScoped<IDoadorService, DoadorService>();

            services.AddScoped<IParceiroQuery, ParceiroRepositorio>();
            services.AddScoped<IParceiroService, ParceiroService>();
        }
    }
}