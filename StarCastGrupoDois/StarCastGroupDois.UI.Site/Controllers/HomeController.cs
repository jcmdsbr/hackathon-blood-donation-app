using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Queries;
using System.Linq;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IDoacaoQuery _doacaoQuery;

        public HomeController(IDoacaoQuery doacaoQuery)
        {
            _doacaoQuery = doacaoQuery;
        }

        public IActionResult Index()
        {

            return View(_doacaoQuery.List().Select(x => (DoacaoViewModel)x));
        }

        public IActionResult EnviarAviso()
        {
            // Todo Implementar...

            return NotificarSucesso("Aviso enviado com sucesso.", () => RedirectToAction(nameof(Index)));
        }

        public IActionResult EnviarEmergencia()
        {
            // Todo Implementar...

            return NotificarSucesso("Pedido de emergencia enviado com sucesso.", () => RedirectToAction(nameof(Index)));
        }
    }
}