using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System.Collections.Generic;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var alertaVM = new List<AlertaViewModel>
            {
                new AlertaViewModel { DescricaoDoacao = "Sangue A+", TipoAlerta = TipoAlerta.AguardandoDoacao },
                new AlertaViewModel { DescricaoDoacao = "Remédio Doril", TipoAlerta = TipoAlerta.AguardandoDoacao },
                new AlertaViewModel { DescricaoDoacao = "Remédio Gincobiloba", TipoAlerta = TipoAlerta.Finalizado },
                new AlertaViewModel { DescricaoDoacao = "Orgão Coração", TipoAlerta = TipoAlerta.Cancelado },

            };

            return View(alertaVM);
        }
    }
}