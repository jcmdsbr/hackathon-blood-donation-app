using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Repository.Core
{
    public interface IRepository<in TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
