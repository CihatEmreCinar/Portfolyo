using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
