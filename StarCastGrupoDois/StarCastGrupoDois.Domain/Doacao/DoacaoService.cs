using StarCastGrupoDois.Application.Domain.Alerta;
using StarCastGrupoDois.Application.Domain.Doador;
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
        private readonly IEnvioEmailService _envioEmailService;
        private readonly IDoadorQuery _doadorQuery;

        public DoacaoService(IDoacaoRepositorio doacaoRepositorio, IEnvioEmailService envioEmailService, 
            IDoadorQuery doadorQuery, IUnitOfWork uow) : base(uow)
        {
            _doacaoRepositorio = doacaoRepositorio;
            _envioEmailService = envioEmailService;
            _doadorQuery = doadorQuery;
        }
        public override void Salvar(Entities.Models.Doacao obj)
        {
            obj.CriarNovoCodigo();

            _doacaoRepositorio.Add(obj);

            Commit();

            //if (Commit() && obj.IsEmitirAviso)
            //    _envioEmailService.Enviar($"Precisa-se de doação do tipo {obj.TipoDoacao.ToString()}", _doadorQuery.GetAllEmails());

        }
    }
}
