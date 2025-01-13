using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Web.Features.Organization.ViewModels;

namespace Progetto_UI.Web.Features.Organization
{
    public partial class RicercaController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new RicercaViewModel();
            return View(viewModel);
        }
    }
}
