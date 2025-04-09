using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services.Shared;
using System.Threading.Tasks;
using System;

namespace Progetto_UI.Web.Features.Inserimento
{
    public partial class InserimentoController : Controller
    {

        private readonly SharedService _sharedService;

        public InserimentoController(SharedService sharedService)
        {
            _sharedService = sharedService;
        }

        [HttpPost]
        public async Task<IActionResult> AssignPieceToSpace(int pieceId, int spaceId)
        {
            try
            {
                var command = new AssignPieceToSpaceCommand
                {
                    PieceId = pieceId,
                    SpaceId = spaceId
                };

                await _sharedService.AssignPieceToSpace(command);

                return Json(new { success = true, message = "Pezzo assegnato allo spazio con successo." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new InserimentoViewModel();
            return View("Inserimento", viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
