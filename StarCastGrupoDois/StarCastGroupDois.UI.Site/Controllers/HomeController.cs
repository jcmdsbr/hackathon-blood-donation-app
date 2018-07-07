using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using StarCastGrupoDois.Application.Domain.Doacao;
using System.Collections.Generic;
using System.Linq;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDoacaoQuery _doacaoQuery;

        public HomeController(IDoacaoQuery doacaoQuery)
        {
            _doacaoQuery = doacaoQuery;
        }
        public IActionResult Index()
        {
            var doacaoVM = _doacaoQuery.List().Select(x => (DoacaoViewModel)x);

            return View(doacaoVM.Any() ? doacaoVM : new List<DoacaoViewModel>());
        }
    }
}