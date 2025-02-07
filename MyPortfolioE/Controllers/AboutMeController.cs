using Microsoft.AspNetCore.Mvc;
using MyPortfolioE.DAL.Context;
using MyPortfolioE.DAL.Entities;
using System.Linq;

namespace MyPortfolioE.Controllers
{
    public class AboutMeController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var value = context.Abouts.FirstOrDefault(); // İlk kaydı al
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            var entity = context.Abouts.FirstOrDefault(a => a.AboutId == about.AboutId);
            if (entity != null)
            {
                entity.Detail = about.Detail; // Yeni değeri güncelle
                context.SaveChanges();
            }
            return RedirectToAction("Index"); // Sayfayı yeniden yükle
        }
    }
}
