using Microsoft.AspNetCore.Mvc;
using P138Database.DataAccessLayer;
using P138Database.Models;

namespace P138Database.Controllers
{
    public class ModelController : Controller
    {
        private readonly AppDbContext _context;

        public ModelController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();

            if(_context.Models.Any(s=>s.MarkaId == id)) return NotFound();

            return View(_context.Models.Where(s=>s.MarkaId==id).ToList());
        }
    }
}
