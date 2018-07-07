using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Domain.Entities.Fixed;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class DoacaoController : Controller
    {
        public IActionResult Index()
        {
            var listaTipoDoacao = Enum.GetValues(typeof(TipoDoacao)).Cast<TipoDoacao>().ToList();
            ViewBag.TipoDoacao = new List<SelectListItem>(listaTipoDoacao.Select(x => new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() }));
            var listaTipoSanguineo = Enum.GetValues(typeof(TipoSangue)).Cast<TipoSangue>().ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Index(DoacaoViewModel request)
        {
            return RedirectToAction("Index");
        }
    }
}