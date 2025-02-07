using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
