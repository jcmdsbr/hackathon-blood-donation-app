using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Alerta;
using StarCastGrupoDois.Domain.Entities.Fixed;
using StarCastGrupoDois.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace StarCastGroupDois.UI.Site.Controllers
{
    public class AlertaController : Controller
    {
        private readonly IAlertaService _alertaService;

        public AlertaController(IAlertaService alertaService)
        {
            _alertaService = alertaService;
        }

        public IActionResult Index()
        {
            var alertas = (List<Alerta>)_alertaService.BuscarAlertas();
            var listAlertasVm = alertas.Select(x => (AlertaViewModel)x);
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
        public IActionResult Visualizar(Guid codigoAlerta)
        {
            return View();
        }
    }
}