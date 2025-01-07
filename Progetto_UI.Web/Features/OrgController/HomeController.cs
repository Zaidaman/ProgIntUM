using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.OrgController
{
    public partial class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
