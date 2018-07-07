using Microsoft.AspNetCore.Mvc;
using StarCastGroupDois.UI.Site.Models;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class ParceiroController : Controller
    {
        public IActionResult Index()
        {
            return View(new ParceiroViewModel());
        }

        [HttpPost]
        public IActionResult Index(ParceiroViewModel request)
        {
            return View(request);
        }
    }
}