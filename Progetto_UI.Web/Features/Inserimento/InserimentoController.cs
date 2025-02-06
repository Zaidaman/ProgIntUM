using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Inserimento
{
    public partial class InserimentoController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new InserimentoViewModel();
            return View(viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return View("~/Features/Home/home.cshtml");
        }
    }
}
