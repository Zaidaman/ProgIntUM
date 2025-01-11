using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Organization
{
    public partial class ConsegnaController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            return View();
        }
    }
}
