using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services.Shared;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Web.Features.Home
{
    public partial class HomeController : Controller
    {

        private readonly SharedService _sharedService;

        public HomeController(SharedService sharedService)
        {
            _sharedService = sharedService;
        }

        [HttpGet]
        public virtual IActionResult Index()
        {
            var model = new HomeViewModel();
            return View("Home", model);
        }

        [HttpGet]
        public virtual IActionResult Login()
        {
            RemoveRememberMeCookie();
            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public virtual IActionResult Inserimento()
        {
            return RedirectToAction("Index", "Inserimento");
        }

        [HttpGet]
        public virtual IActionResult Consegna()
        {
            return RedirectToAction("Index", "Consegna");
        }

        [HttpGet]
        public virtual IActionResult Spostamento()
        {
            return RedirectToAction("Index", "Spostamento");
        }

        [HttpGet]
        public virtual IActionResult Ricerca()
        {
            return RedirectToAction("Index", "Ricerca");
        }

        private void RemoveRememberMeCookie()
        {
            if (Request.Cookies.ContainsKey(".AspNetCore.Cookies"))
            {
                Response.Cookies.Delete(".AspNetCore.Cookies");
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> StampaInventario()
        {
            var data = await _sharedService.QueryAllSpacesWithPiece();

            var sb = new StringBuilder();
            sb.AppendLine("Area,Codice Pezzo");
            foreach (var item in data)
            {
                sb.AppendLine($"{item.SpaceId},{(item.PieceId.HasValue ? item.PieceId.Value.ToString() : "")}");
            }

            var bytes = Encoding.UTF8.GetBytes(sb.ToString());
            return File(bytes, "text/csv", "inventario.csv");
        }
    }
}