using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using System.Linq;

namespace Portfolio.Controllers
{
    public class CertificateController : Controller
    {
        private readonly AppDbContext _context;

        public CertificateController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Sertifikalar - Admin Panel";
            ViewData["PageTitle"] = "Sertifikalar";

            var certificates = _context.Certificates.ToList();

            ViewBag.CertificateCount = certificates.Count;

            return View(certificates);
        }
    }
}
