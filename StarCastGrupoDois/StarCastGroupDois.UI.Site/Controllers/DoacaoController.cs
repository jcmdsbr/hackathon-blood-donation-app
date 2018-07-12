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
    public class DoacaoController : Controller
    {
        private readonly IDoacaoService _doacaoService;

        public DoacaoController(IDoacaoService doacaoService)
        {
            _doacaoService = doacaoService;
        }

        public IActionResult Index()
        {
            var listaTipoDoacao = Enum.GetValues(typeof(TipoDoacao)).Cast<TipoDoacao>().ToList();
            ViewBag.TipoDoacao = new List<SelectListItem>(listaTipoDoacao.Select(x =>
                new SelectListItem { Text = x.ToString(), Value = ((int)x).ToString() }));
            var listaTipoSanguineo = Enum.GetValues(typeof(TipoSangue)).Cast<TipoSangue>().ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(DoacaoViewModel request)
        {
            _doacaoService.Salvar(request);
            TempData["Success"] = "Doação cadastrada com sucesso";
            return RedirectToAction("Index", "Home");
        }
    }
}