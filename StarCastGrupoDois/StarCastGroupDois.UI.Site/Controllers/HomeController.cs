using Microsoft.AspNetCore.Mvc;

namespace StarCastGroupDois.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}