using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace StarCastGroupDois.UI.Site.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected IActionResult NotificarSucesso(string mensagem, Func<IActionResult> retorno)
        {
            TempData["Success"] = mensagem;

            return retorno();
        }
    }
}