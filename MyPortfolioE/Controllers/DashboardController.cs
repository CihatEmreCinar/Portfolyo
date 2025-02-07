using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
