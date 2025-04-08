using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services;
using Progetto_UI.Services.Shared;
using System;
using System.Linq;

namespace Progetto_UI.Web.Features.Ricerca
{
    [Route("ricerca")]
    public partial class RicercaController : Controller
    {
        private readonly TemplateDbContext _context;

        public RicercaController(TemplateDbContext context)
        {
            _context = context;
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
        public virtual IActionResult GetProductById(int id)
        {
            var product = _context.Piece
                                  .Where(p => p.Id == id)
                                  .Select(p => new
                                  {
                                      p.Id,
                                      p.Name,
                                      p.Description
                                  })
                                  .FirstOrDefault();

            if (product == null)
            {
                return NotFound(new { message = "Prodotto non trovato" });
            }

            return Ok(product);
        }
    }
}
