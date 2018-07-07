using System.Collections.Generic;
using StarCastGrupoDois.Application.Domain.Doador;
using StarCastGrupoDois.Application.Repository.Doador;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Domain.Entities.ValueObject;
using StarCastGrupoDois.Infra.Repository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class DoadorRepositorio : RepositorioBase<Doador>, IDoadorRepositorio, IDoadorQuery
    {
        public DoadorRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }

        public List<Email> GetAllEmails()
        {
           return DbSet.AsNoTracking().Select(x=>x.Email).ToList();
        }
    }
}
