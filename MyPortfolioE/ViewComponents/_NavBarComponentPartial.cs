using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents
{
    public class _NavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
