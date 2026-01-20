using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace Portfolio.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultExperienceComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var experienceList = _context.Experiences.ToList();
            return View(experienceList);
        }
    }
}
