using ASP_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View("Index", categories);
        }
    }
}
