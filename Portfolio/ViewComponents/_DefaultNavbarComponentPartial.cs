using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _DefaultNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
