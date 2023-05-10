using Microsoft.AspNetCore.Mvc;
using P138Database.DataAccessLayer;

namespace P138Database.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context) 
        {
            _context= context;
        }

        public IActionResult Index()
        {
            return View(_context.Markas.ToList());
        }
    }
}
