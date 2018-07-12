using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Application.Repository;
using StarCastGrupoDois.Domain.Core;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Domain.Services
{
    public class DoacaoService : ServiceBase<Doacao>, IDoacaoService
    {
        private readonly IDoacaoRepositorio _doacaoRepositorio;
        private readonly IDoadorQuery _doadorQuery;
        private readonly IEnvioEmailService _envioEmailService;

        public DoacaoService(IDoacaoRepositorio doacaoRepositorio, IEnvioEmailService envioEmailService,
            IDoadorQuery doadorQuery, IUnitOfWork uow) : base(uow)
        {
            _doacaoRepositorio = doacaoRepositorio;
            _envioEmailService = envioEmailService;
            _doadorQuery = doadorQuery;
        }

        public override void Salvar(Doacao obj)
        {
            obj.CriarNovoCodigo();

            _doacaoRepositorio.Add(obj);

            Commit();

            //if (Commit() && obj.IsEmitirAviso)
            //    _envioEmailService.Enviar($"Precisa-se de doação do tipo {obj.TipoDoacao.ToString()}", _doadorQuery.GetAllEmails());
        }
    }
}