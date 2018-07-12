using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Core;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Domain.Services
{
    public class DoadorService : ServiceBase<Doador>, IDoadorService
    {
        private readonly IDoadorRepositorio _doadorRepositorio;

        public DoadorService(IDoadorRepositorio doadorRepositorio, IUnitOfWork uow) : base(uow)
        {
            _doadorRepositorio = doadorRepositorio;
        }

        public override void Salvar(Doador obj)
        {
            _doadorRepositorio.Add(obj);

            Commit();
        }
    }
}