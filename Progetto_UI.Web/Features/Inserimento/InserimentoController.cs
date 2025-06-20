﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public virtual async Task<IActionResult> AssignPieceToSpace(int pieceId, int SpaceId)
        {
            try
            {
                var cmd = new AssignPieceToSpaceCommand
                {
                    PieceId = pieceId,
                    SpaceId = SpaceId
                };

                await _sharedService.AssignPieceToSpace(cmd);

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
