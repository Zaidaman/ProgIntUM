using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Progetto_UI.Web.Features.Organization.ViewModels;

namespace Progetto_UI.Web.Features.Organization
{
    public partial class SpostamentoController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            return View(new SpostamentoViewModel());
        }

        [HttpPost]
        public virtual IActionResult Index(SpostamentoViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Logica per gestire il form
                // ...

                // Mostra l'overlay o un messaggio di successo
                ViewBag.Message = "Il pezzo è stato registrato nella nuova area.";
            }

            return View(model);
        }
    }
}
