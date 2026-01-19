using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
