using Microsoft.AspNetCore.Mvc;
using Portfolio.Entities;
using System.Collections.Generic;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        // Deneyimler listesi
        public IActionResult Index()
        {
            ViewData["Title"] = "Deneyimlerim - Admin Panel";
            ViewData["PageTitle"] = "Deneyimlerim";

            // Şimdilik boş liste (ileride DB bağlanır)
            List<Experience> experiences = new List<Experience>();

            return View(experiences);
        }

        // Yeni deneyim ekleme sayfası
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Yeni Deneyim Ekle - Admin Panel";
            ViewData["PageTitle"] = "Yeni Deneyim Ekle";
            return View();
        }

        // Yeni deneyim ekleme işlemi
        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Yeni Deneyim Ekle - Admin Panel";
                ViewData["PageTitle"] = "Yeni Deneyim Ekle";
                return View(experience);
            }

            // DB kayıt işlemi burada yapılacak

            return RedirectToAction("Index");
        }

        // Deneyim düzenleme sayfası
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Deneyim Düzenle - Admin Panel";
            ViewData["PageTitle"] = "Deneyim Düzenle";

            // DB'den tek kayıt çekilecek (şimdilik dummy)
            Experience experience = new Experience
            {
                ExperienceId = id
            };

            return View(experience);
        }

        // Deneyim düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Deneyim Düzenle - Admin Panel";
                ViewData["PageTitle"] = "Deneyim Düzenle";
                return View(experience);
            }

            // DB update işlemi burada yapılacak

            return RedirectToAction("Index");
        }

        // Deneyim silme
        public IActionResult Delete(int id)
        {
            // DB delete işlemi burada yapılacak

            return RedirectToAction("Index");
        }
    }
}
