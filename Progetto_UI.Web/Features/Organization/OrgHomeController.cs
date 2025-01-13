using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Organization.ViewModels
{
    public partial class OrgHomeController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Title = "Gestione Semi-elaborati",
                ImageUrl = "./icons/warehouse.jpg"
            };
            return View("Home", model);
        }
    }
}