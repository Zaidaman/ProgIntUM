using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services.Shared;
using System.Threading.Tasks;
using System;

namespace Progetto_UI.Web.Features.Consegna
{
    public partial class ConsegnaController : Controller
    {

        private readonly SharedService _sharedService;

        public ConsegnaController(SharedService sharedService)
        {
            _sharedService = sharedService;
        }

        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new ConsegnaViewModel();
            return View("Consegna", viewModel);
        }

        [HttpGet]
        public virtual IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public virtual async Task<IActionResult> RemovePieceFromSpace(int spaceId)
        {
            try
            {
                var cmd = new RemovePieceFromSpaceCommand
                {
                    SpaceId = spaceId
                };

                await _sharedService.RemovePieceFromSpace(cmd);

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
