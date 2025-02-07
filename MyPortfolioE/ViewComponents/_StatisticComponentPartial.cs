using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
