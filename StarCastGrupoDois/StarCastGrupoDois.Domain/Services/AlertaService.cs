using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using StarCastGrupoDois.Domain.Entities.Models;
using System;

namespace StarCastGrupoDois.Domain.Services
{
    public class AlertaService : ServiceBase<Alerta>, IAlertaService
    {
        private readonly IAlertaQuery _alertaQuery;
        private readonly IAlertaRepositorio _alertaRepositorio;

        public AlertaService(IAlertaRepositorio alertaRepositorio, IUnitOfWork uow, IAlertaQuery alertaQuery) :
            base(uow)
        {
            _alertaRepositorio = alertaRepositorio;
            _alertaQuery = alertaQuery;
        }

        public override void Salvar(Alerta obj)
        {
            if (obj.Codigo != Guid.Empty)
            {
                _alertaRepositorio.Update(obj);
            }
            else
            {
                obj.CriarNovoCodigo();
                obj.CriarDataConclusao(DateTime.Now.AddDays(5));
                obj.CriarEmissaoDeAlerta();

                _alertaRepositorio.Add(obj);
            }

            Commit();
        }

        public void AlterarStatus(Guid codigo, TipoAlerta tipoAlerta)
        {
            var alerta = _alertaQuery.Find(x => x.Codigo == codigo);

            alerta.AlterarAlerta(tipoAlerta);

            Salvar(alerta);
        }
    }
}