using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _DefaultEducationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
            { return View(); }
    }
}
