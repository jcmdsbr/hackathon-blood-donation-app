using StarCastGrupoDois.Application.Domain.Doador;
using StarCastGrupoDois.Application.Repository.Doador;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class DoadorRepositorio : RepositorioBase<Doador>, IDoadorRepositorio, IDoadorQuery
    {
        protected DoadorRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}
