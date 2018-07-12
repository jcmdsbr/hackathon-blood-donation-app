using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class ParceiroRepositorio : RepositorioBase<Parceiro>, IParceiroRepositorio, IParceiroQuery
    {
        public ParceiroRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}