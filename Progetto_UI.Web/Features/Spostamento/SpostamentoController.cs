using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Spostamento
{
    public partial class SpostamentoController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            return View(new SpostamentoViewModel());
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return View("~/Features/Home/home.cshtml");
        }
    }
}
