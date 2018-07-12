using System;
using System.Collections.Generic;

namespace StarCastGrupoDois.Application.Core
{
    public interface IQuery<TEntity>
    {
        TEntity Find(Func<TEntity, bool> expression);
        ICollection<TEntity> List();
    }
}