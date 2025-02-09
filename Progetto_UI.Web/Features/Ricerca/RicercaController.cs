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
            Console.WriteLine($"🔍 Ricerca per ProductId: {id}"); // Debug

            var product = _context.Products
                                  .Where(p => p.ProductId == id)
                                  .Select(p => new
                                  {
                                      p.ProductId,
                                      p.Name,
                                      p.Description
                                  })
                                  .FirstOrDefault();

            if (product == null)
            {
                Console.WriteLine($"❌ Prodotto con ID {id} non trovato");
                return NotFound(new { message = "Prodotto non trovato" });
            }

            Console.WriteLine($"✅ Prodotto trovato: {product.Name}");
            return Ok(product);
        }
    }
}
