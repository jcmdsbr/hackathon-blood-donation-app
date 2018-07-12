using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Domain.Entities.ValueObject;
using StarCastGrupoDois.Infra.Repository.Context;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public class DoadorRepositorio : RepositorioBase<Doador>, IDoadorRepositorio, IDoadorQuery
    {
        public DoadorRepositorio(StarCastGroupoDoisContexto db) : base(db)
        {
        }

        public List<Email> GetAllEmails()
        {
            return DbSet.AsNoTracking().Select(x => x.Email).ToList();
        }
    }
}