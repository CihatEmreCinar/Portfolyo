using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents.LayoutHeadComponent
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
