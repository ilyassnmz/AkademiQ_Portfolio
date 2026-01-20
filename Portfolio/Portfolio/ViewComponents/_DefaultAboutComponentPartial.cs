using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace Portfolio.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
            { 
                var aboutList = _context.Abouts.ToList();
                return View(aboutList); 
            }
    }
}
