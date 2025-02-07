using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
