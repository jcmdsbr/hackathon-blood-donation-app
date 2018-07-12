using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Infra.CrossCutting.Messages;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class ParceiroController : Controller
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

            TempData["Success"] = string.Format(MensagensGerais.CADASTRADO_COM_SUCESSO, "Parceiro");

            return RedirectToAction("Index", "Home");
        }
    }
}