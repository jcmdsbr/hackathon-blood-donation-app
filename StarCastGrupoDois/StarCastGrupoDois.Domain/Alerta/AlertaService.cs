using System;
using System.Collections.Generic;
using System.Text;
using StarCastGrupoDois.Application.Repository.Alerta;
using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Domain.Core;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Domain.Alerta
{
    public class AlertaService :   ServiceBase<Entities.Models.Alerta> , Application.Domain.Alerta.IAlertaService
    {
        private readonly IAlertaRepositorio _alertaRepositorio;

        public AlertaService(IAlertaRepositorio alertaRepositorio, IUnitOfWork uow) : base(uow)
        {
            _alertaRepositorio = alertaRepositorio;
        }
        public override void Salvar(Entities.Models.Alerta obj)
        {
            _alertaRepositorio.Add(obj);

            Commit();
           
        }
    }
}
