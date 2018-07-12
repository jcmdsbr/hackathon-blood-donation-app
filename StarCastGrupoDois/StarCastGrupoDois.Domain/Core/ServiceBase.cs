using StarCastGrupoDois.Application.Core;

namespace StarCastGrupoDois.Domain.Core
{
    public abstract class ServiceBase<TEntity> : IService<TEntity>
    {
        private readonly IUnitOfWork _uow;

        protected ServiceBase(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public abstract void Salvar(TEntity obj);

        protected bool Commit()
        {
            return _uow.Commit();
        }
    }
}