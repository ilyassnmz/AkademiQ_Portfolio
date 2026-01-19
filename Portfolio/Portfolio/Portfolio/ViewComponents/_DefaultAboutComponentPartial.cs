using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
            { return View(); }
    }
}
