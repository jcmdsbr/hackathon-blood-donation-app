using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class AlertaRepositorio : RepositorioBase<Alerta>, IAlertaQuery, IAlertaRepositorio
    {
        public AlertaRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}