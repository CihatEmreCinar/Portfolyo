using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
