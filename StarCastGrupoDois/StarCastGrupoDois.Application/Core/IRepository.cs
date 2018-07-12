using System;

namespace StarCastGrupoDois.Application.Core
{
    public interface IRepository<in TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}