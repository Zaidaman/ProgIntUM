using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Ricerca
{
    public partial class RicercaController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new RicercaViewModel();
            return View(viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return View("~/Features/Home/home.cshtml");
        }
    }
}
