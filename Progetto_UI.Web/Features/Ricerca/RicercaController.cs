﻿using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services;
using Progetto_UI.Services.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Progetto_UI.Web.Features.Ricerca
{
    [Route("ricerca")]
    public partial class RicercaController : Controller
    {
        private readonly TemplateDbContext _context;
        private readonly SharedService _sharedService;

        public RicercaController(TemplateDbContext context, SharedService sharedService)
        {
            _context = context;
            _sharedService = sharedService;
        }

        [HttpGet]
        public virtual IActionResult Index()
        {
            var viewModel = new RicercaViewModel();
            return View("Ricerca", viewModel);
        }

        [HttpGet("home")]
        public virtual IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("api/products/{id}")]
        public virtual async Task<IActionResult> GetProductById(int id)
        {
            var query = new FindPieceByIdQuery { PieceId = id };
            var result = await _sharedService.Query(query);

            if (result == null)
                return NotFound();

            // Adatta la risposta secondo le proprietà di FindPieceByIdDTO
            return Json(new
            {
                productId = result.Id,
                name = result.Name,
                description = result.Description,
                spaceId = result.SpaceId
            });
        }
    }
}
