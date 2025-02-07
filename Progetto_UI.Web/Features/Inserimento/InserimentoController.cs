using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Inserimento
{
    public partial class InserimentoController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new InserimentoViewModel();
            return View("Inserimento", viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
