using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class DoacaoRepositorio : RepositorioBase<Doacao>, IDoacaoRepositorio, IDoacaoQuery
    {
        public DoacaoRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}