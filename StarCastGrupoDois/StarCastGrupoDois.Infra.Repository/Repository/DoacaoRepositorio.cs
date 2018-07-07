using StarCastGrupoDois.Application.Domain.Doacao;
using StarCastGrupoDois.Application.Repository.Doacao;
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
