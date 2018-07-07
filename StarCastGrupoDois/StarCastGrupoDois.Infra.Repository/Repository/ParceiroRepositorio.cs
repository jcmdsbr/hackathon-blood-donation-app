using StarCastGrupoDois.Application.Domain.Parceiro;
using StarCastGrupoDois.Application.Repository.Parceiro;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class ParceiroRepositorio : RepositorioBase<Parceiro> , IParceiroRepositorio, IParceiroQuery
    {
        protected ParceiroRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }
    }
}
