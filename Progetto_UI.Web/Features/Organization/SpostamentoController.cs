using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Progetto_UI.Web.Features.Organization
{
    public partial class SpostamentoController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            return View();
        }
    }
}
