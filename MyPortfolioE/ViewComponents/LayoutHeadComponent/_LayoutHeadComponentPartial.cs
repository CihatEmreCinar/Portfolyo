using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents.LayoutHeadComponent
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
