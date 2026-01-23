using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var works = _context.Works.ToList();

            ViewBag.WorkCount = works.Count;

            return View(works);
        }
    }
}
