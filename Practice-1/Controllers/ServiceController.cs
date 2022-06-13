using Microsoft.AspNetCore.Mvc;
using Practice_1.DAL;
using Practice_1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Practice_1.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Card> cards = _context.Cards.ToList();
            return View(cards);
        }
    }
}
