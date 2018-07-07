using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Application.Repository.Doador;
using StarCastGrupoDois.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Domain.Doador
{
    public class DoadorService : ServiceBase<StarCastGrupoDois.Domain.Entities.Models.Doador>, Application.Domain.Doador.IDoadorService
    {
        private readonly IDoadorRepositorio _doadorRepositorio;

        public DoadorService(IDoadorRepositorio doadorRepositorio, IUnitOfWork uow) : base(uow)
        {
            _doadorRepositorio = doadorRepositorio;
        }
        public override void Salvar(StarCastGrupoDois.Domain.Entities.Models.Doador obj)
        {
            _doadorRepositorio.Add(obj);

            Commit();

        }
    }
}
