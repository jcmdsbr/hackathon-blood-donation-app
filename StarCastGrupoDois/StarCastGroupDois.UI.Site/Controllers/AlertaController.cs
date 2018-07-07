using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System.Collections.Generic;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class AlertaController : Controller
    {
        public IActionResult Index()
        {
            var alertaVM = new List<AlertaViewModel>
            {
                new AlertaViewModel { DescricaoDoacao = "Remédio Doril", TipoAlerta = TipoAlerta.AguardandoDoacao },
                new AlertaViewModel { DescricaoDoacao = "Remédio Gincobiloba", TipoAlerta = TipoAlerta.AguardandoDoacao }

            };

            return View(alertaVM);
        }
    }
}