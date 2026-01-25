using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.Controllers
{
    public class AdminController : Controller
    {
        // Ana dashboard sayfası
        public IActionResult Dashboard()
        {
            ViewData["Title"] = "Dashboard - Admin Panel";
            ViewData["PageTitle"] = "Genel Bakış";
            return View();
        }

        // Projelerim sayfası
        public IActionResult Projects()
        {
            ViewData["Title"] = "Projelerim - Admin Panel";
            ViewData["PageTitle"] = "Projelerim";
            return View();
        }

        // Yeteneklerim sayfası
        public IActionResult Skills()
        {
            ViewData["Title"] = "Yeteneklerim - Admin Panel";
            ViewData["PageTitle"] = "Yeteneklerim";
            return View();
        }

        // Deneyimlerim sayfası
        public IActionResult Experience()
        {
            ViewData["Title"] = "Deneyimlerim - Admin Panel";
            ViewData["PageTitle"] = "Deneyimlerim";
            return View();
        }

        // Mesajlar sayfası
        public IActionResult Messages()
        {
            ViewData["Title"] = "Mesajlar - Admin Panel";
            ViewData["PageTitle"] = "Mesajlar";
            return View();
        }

        // Hakkımda sayfası
        public IActionResult About()
        {
            ViewData["Title"] = "Hakkımda - Admin Panel";
            ViewData["PageTitle"] = "Hakkımda";
            return View();
        }

        // Sertifikalarım sayfası
        public IActionResult Certificates()
        {
            ViewData["Title"] = "Sertifikalarım - Admin Panel";
            ViewData["PageTitle"] = "Sertifikalarım";
            return View();
        }

        // İletişim sayfası
        public IActionResult Contact()
        {
            ViewData["Title"] = "İletişim - Admin Panel";
            ViewData["PageTitle"] = "İletişim";
            return View();
        }
    }
}