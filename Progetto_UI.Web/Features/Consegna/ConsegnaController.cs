using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Progetto_UI.Services;

namespace Progetto_UI.Web.Features.Consegna
{
    public partial class ConsegnaController : Controller
    {
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

        private readonly TemplateDbContext _context;

        public ConsegnaController(TemplateDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public virtual IActionResult GetAllProducts()
        {
            var products = _context.Piece.ToList();
            return Ok(products);
        }
        [HttpGet]
        public virtual IActionResult GetAllSpaces()
        {
            var space = _context.Space.ToList();
            return Ok(space);
        }
    }
}
