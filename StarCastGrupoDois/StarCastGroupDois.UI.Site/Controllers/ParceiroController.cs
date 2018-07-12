using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Infra.CrossCutting.Messages;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class ParceiroController : BaseController
    {
        private readonly IParceiroService _parceiroService;

        public ParceiroController(IParceiroService parceiroService)
        {
            _parceiroService = parceiroService;
        }

        public IActionResult Index()
        {
            return View(new ParceiroViewModel());
        }

        [HttpPost]
        public IActionResult Index(ParceiroViewModel request)
        {
            _parceiroService.Salvar(request);

            var mensagemSucesso = string.Format(MensagensGerais.CADASTRADO_COM_SUCESSO, "Parceiro");

            return NotificarSucesso(mensagemSucesso, () => RedirectToAction("Index", "Home"));

        }
    }
}