using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Core;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Domain.Services
{
    public class ParceiroService : ServiceBase<Parceiro>, IParceiroService
    {
        private readonly IParceiroRepositorio _parceiroRepositorio;


        public ParceiroService(IParceiroRepositorio parceiroRepositorio, IUnitOfWork uow) : base(uow)
        {
            _parceiroRepositorio = parceiroRepositorio;
        }

        public override void Salvar(Parceiro obj)
        {
            obj.CriarNovoCodigo();
            _parceiroRepositorio.Add(obj);

            Commit();
        }
    }
}