using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Consegna
{
    public partial class ConsegnaController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new ConsegnaViewModel();
            return View(viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return View("~/Features/Home/home.cshtml");
        }
    }
}
