using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Home
{
    public partial class HomeController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Title = "Gestione Semi-elaborati",
                ImageUrl = "./Icons/warehouse.jpg"
            };
            return View("Home", model);
        }

        [HttpGet]
        public virtual IActionResult Login()
        {
            return View("~/Features/Login/login.cshtml");
        }

        [HttpGet]
        public virtual IActionResult Inserimento()
        {
            return View("~/Features/Inserimento/inserimento.cshtml");
        }

        [HttpGet]
        public virtual IActionResult Consegna()
        {
            return View("~/Features/Consegna/consegna.cshtml");
        }

        [HttpGet]
        public virtual IActionResult Spostamento()
        {
            return View("~/Features/Spostamento/spostamento.cshtml");
        }

        [HttpGet]
        public virtual IActionResult Ricerca()
        {
            return View("~/Features/Ricerca/ricerca.cshtml");
        }
    }
}