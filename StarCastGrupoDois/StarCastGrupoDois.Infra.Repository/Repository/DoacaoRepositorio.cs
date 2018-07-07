using StarCastGrupoDois.Application.Domain.Doacao;
using StarCastGrupoDois.Application.Repository.Doacao;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class DoacaoRepositorio : RepositorioBase<Doacao>, IDoacaoRepositorio, IDoacaoQuery
    {
        protected DoacaoRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}
