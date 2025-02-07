using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents.LayoutHeadComponent
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
