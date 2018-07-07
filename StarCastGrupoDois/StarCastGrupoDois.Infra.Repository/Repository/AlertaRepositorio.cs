using StarCastGrupoDois.Application.Domain.Alerta;
using StarCastGrupoDois.Application.Repository.Alerta;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class AlertaRepositorio : RepositorioBase<Alerta> , IAlertaQuery , IAlertaRepositorio
    {
        protected AlertaRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}
