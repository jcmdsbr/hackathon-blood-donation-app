using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StarCastGroupDois.UI.Site.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}