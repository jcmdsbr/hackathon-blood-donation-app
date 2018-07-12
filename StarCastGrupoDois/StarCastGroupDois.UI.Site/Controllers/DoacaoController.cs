using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class DoacaoController : BaseController
    {
        private readonly IDoacaoService _doacaoService;
        private readonly IEnumerable<TipoDoacao> _tipoDoacaos = Enum.GetValues(typeof(TipoDoacao)).Cast<TipoDoacao>();

        public DoacaoController(IDoacaoService doacaoService)
        {
            _doacaoService = doacaoService;
        }

        public IActionResult Index()
        {

            ViewBag.TipoDoacao = _tipoDoacaos.Select(x => new SelectListItem { Text = x.ToString(), Value = ((int)x).ToString() });

            return View();
        }

        [HttpPost]
        public IActionResult Index(DoacaoViewModel request)
        {
            _doacaoService.Salvar(request);

            return NotificarSucesso("Doação cadastrada com sucesso", () => RedirectToAction("Index", "Home"));
        }
    }
}