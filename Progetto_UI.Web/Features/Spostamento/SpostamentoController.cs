using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services.Shared;

namespace Progetto_UI.Web.Features.Spostamento
{
    public partial class SpostamentoController : Controller
    {
        private readonly SharedService _sharedService;
        public SpostamentoController(SharedService sharedService)
        {
            _sharedService = sharedService;
        }

        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new SpostamentoViewModel();
            return View("Spostamento", viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public virtual async Task<IActionResult> MovePieceToAnotherSpace(int pieceId, int SpaceId)
        {
            try
            {
                var cmd = new MovePieceToAnotherSpaceCommand
                {
                    PieceId = pieceId,
                    NewSpaceId = SpaceId
                };

                await _sharedService.MovePieceToAnotherSpace(cmd);

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
