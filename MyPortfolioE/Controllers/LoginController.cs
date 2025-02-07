using Microsoft.AspNetCore.Mvc;
using MyPortfolioE.DAL.Context;

namespace MyPortfolioE.Controllers
{
    public class LoginController : Controller
    {
       MyPortfolioContext context = new MyPortfolioContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            Console.WriteLine($"Username: {username}, Password: {password}"); // Konsola yazdırmak

            var user = context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Kullanıcı bulundu, Dashboard sayfasına yönlendir
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                // Kullanıcı bulunamadı, hata mesajı göster
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı!";
                return View();
            }
        }

    }
}
