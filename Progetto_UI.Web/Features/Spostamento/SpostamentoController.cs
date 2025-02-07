using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Spostamento
{
    public partial class SpostamentoController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new SpostamentoViewModel();
            return View("Spostamento", viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
