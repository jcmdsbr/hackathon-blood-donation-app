using System;
using System.Collections.Generic;
using System.Text;
using StarCastGrupoDois.Application.Domain.Alerta;
using StarCastGrupoDois.Application.Repository.Alerta;
using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Domain.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Domain.Alerta
{
    public class AlertaService : ServiceBase<Entities.Models.Alerta>, Application.Domain.Alerta.IAlertaService
    {
        private readonly IAlertaRepositorio _alertaRepositorio;
        private readonly IAlertaQuery _alertaQuery;

        public AlertaService(IAlertaRepositorio alertaRepositorio, IUnitOfWork uow, IAlertaQuery alertaQuery) : base(uow)
        {
            _alertaRepositorio = alertaRepositorio;
            _alertaQuery = alertaQuery;
        }
        public override void Salvar(Entities.Models.Alerta obj)
        {
            if (obj.Codigo != Guid.Empty)
            {
                _alertaRepositorio.Update(obj);
            } else
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

        public ICollection<Entities.Models.Alerta> BuscarAlertas(){
            return _alertaQuery.List();
        }
    }
}
