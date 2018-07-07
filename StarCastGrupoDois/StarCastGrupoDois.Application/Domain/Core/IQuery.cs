using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Domain.Core
{
    public interface IQuery<TEntity>
    {
        TEntity Find(Func<TEntity, bool> expression);
        ICollection<TEntity> List();
    }
}
