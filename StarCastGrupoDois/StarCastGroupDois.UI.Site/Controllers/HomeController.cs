using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;
using System.Collections.Generic;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<AlertaViewModel>());
        }
    }
}