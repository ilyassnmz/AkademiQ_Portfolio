using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using System.Linq;

namespace Portfolio.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Mesajlar - Admin Panel";
            ViewData["PageTitle"] = "Mesajlar";

            var messages = _context.Messages
                                   .OrderByDescending(x => x.SendDate)
                                   .ToList();

            return View(messages);
        }
    }
}
