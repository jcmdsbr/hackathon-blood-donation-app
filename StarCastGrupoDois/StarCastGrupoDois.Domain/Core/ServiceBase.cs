using StarCastGrupoDois.Application.Domain.Core;
using StarCastGrupoDois.Application.Repository.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Domain.Core
{
    public abstract class ServiceBase<TEntity> : IService<TEntity>
    {
        public abstract void Salvar(TEntity obj);

        private readonly IUnitOfWork _uow;

        protected ServiceBase(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected bool Commit()
        {
            return _uow.Commit();
        }
    }
}
