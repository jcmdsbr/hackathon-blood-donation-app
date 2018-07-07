using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Application.Repository.Doacao;
using StarCastGrupoDois.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Domain.Doacao
{
    public class DoacaoService : ServiceBase<Entities.Models.Doacao>, Application.Domain.Doacao.IDoacaoService
    {
        private readonly IDoacaoRepositorio _doacaoRepositorio;

        public DoacaoService(IDoacaoRepositorio doacaoRepositorio, IUnitOfWork uow) : base(uow)
        {
            _doacaoRepositorio = doacaoRepositorio;
        }
        public override void Salvar(Entities.Models.Doacao obj)
        {
            _doacaoRepositorio.Add(obj);

            Commit();

        }
    }
}
