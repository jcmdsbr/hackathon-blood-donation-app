using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Alerta;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System.Collections.Generic;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAlertaQuery _alertaQuery;

        public HomeController(IAlertaQuery alertaQuery)
        {
            _alertaQuery = alertaQuery;
        }
        public IActionResult Index()
        {

            var teste = _alertaQuery.List();

            var alertaVM = new List<AlertaViewModel>
            {
                new AlertaViewModel { DescricaoDoacao = "Sangue A+", TipoAlerta = TipoAlerta.Finalizado },
                new AlertaViewModel { DescricaoDoacao = "Remédio Doril", TipoAlerta = TipoAlerta.AguardandoDoacao },
                new AlertaViewModel { DescricaoDoacao = "Remédio Gincobiloba", TipoAlerta = TipoAlerta.AguardandoDoacao },
                new AlertaViewModel { DescricaoDoacao = "Orgão Coração", TipoAlerta = TipoAlerta.Cancelado },

            };

            return View(alertaVM);
        }
    }
}