using Microsoft.AspNetCore.Mvc;
using P138Database.DataAccessLayer;

namespace P138Database.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();

            if (_context.Cars.Any(s => s.ModelId == id)) return NotFound();

            return View(_context.Cars.Where(s => s.ModelId == id).ToList());
        }

        public IActionResult Detail(int? id)
        {
            if(id == null) return BadRequest();

            Models.Car car = _context.Cars.FirstOrDefault(s => s.Id == id);

            if (car == null) return NotFound();

            return View(car);
        }
    }
}
