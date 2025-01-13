using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Web.Features.Organization.ViewModels;

namespace Progetto_UI.Web.Features.Organization
{
    public partial class ConsegnaController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new ConsegnaViewModel();
            return View(viewModel);
        }
    }
}
