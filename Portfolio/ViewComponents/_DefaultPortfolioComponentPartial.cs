using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
