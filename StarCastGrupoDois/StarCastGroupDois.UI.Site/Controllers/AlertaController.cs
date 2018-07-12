using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Queries;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.Linq;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class AlertaController : Controller
    {
        private readonly IAlertaQuery _alertaQuery;
        private readonly IAlertaService _alertaService;


        public AlertaController(IAlertaService alertaService, IAlertaQuery alertaQuery)
        {
            _alertaService = alertaService;
            _alertaQuery = alertaQuery;
        }

        public IActionResult Index()
        {
            var listAlertasVm = _alertaQuery.List().Select(x => (AlertaViewModel)x);

            return View(listAlertasVm);
        }

        public IActionResult CancelarAviso(Guid codigoAlerta)
        {
            _alertaService.AlterarStatus(codigoAlerta, TipoAlerta.Cancelado);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Finalizar(Guid codigoAlerta)
        {
            _alertaService.AlterarStatus(codigoAlerta, TipoAlerta.Finalizado);

            return RedirectToAction("Index", "Home");
        }

        //Todo implementar..
        public IActionResult Visualizar(Guid codigoAlerta)
        {
            return View();
        }
    }
}