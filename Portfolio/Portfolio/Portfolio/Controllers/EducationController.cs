using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiQPortfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly AppDbContext _context;

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult EducationList()
        {
            var educationCount = _context.Educations.Count();

            ViewBag.EducationCount = educationCount;

            return View();
        }
    }
}
