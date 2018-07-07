using StarCastGrupoDois.Application.Domain.Doador;
using StarCastGrupoDois.Application.Repository.Doador;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class DoadorRepositorio : RepositorioBase<Doador>, IDoadorRepositorio, IDoadorQuery
    {
        public DoadorRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}
