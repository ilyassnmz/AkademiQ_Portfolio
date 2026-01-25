using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
