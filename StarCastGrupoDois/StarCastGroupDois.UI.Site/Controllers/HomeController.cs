using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Alerta;
using System.Collections.Generic;
using System.Linq;

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

            var alertaVM = _alertaQuery.List().Select(x => (AlertaViewModel)x);

            return View(alertaVM.Any() ? new List<AlertaViewModel>() : alertaVM);
        }
    }
}