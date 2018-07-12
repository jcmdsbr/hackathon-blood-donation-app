using Microsoft.EntityFrameworkCore;
using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarCastGrupoDois.Infra.Repository.Repository
{
    public abstract class RepositorioBase<TEntity> : IRepository<TEntity>, IQuery<TEntity> where TEntity : class
    {
        protected readonly StarCastGroupoDoisContexto Db;
        protected readonly DbSet<TEntity> DbSet;

        protected RepositorioBase(StarCastGroupoDoisContexto db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }

        public TEntity Find(Func<TEntity, bool> expression)
        {
            return DbSet.AsNoTracking().AsEnumerable().FirstOrDefault(expression);
        }

        public ICollection<TEntity> List()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }
    }
}