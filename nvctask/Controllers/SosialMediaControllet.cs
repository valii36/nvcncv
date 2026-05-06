using Microsoft.AspNetCore.Mvc;
using nvctask.Data;
using nvctask.Models;

namespace nvctask.Controllers
{
    public class SosialMediaControllet : Controller
    {
        private readonly AppDbContext _context;

        public SosialMediaControllet(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sosialMedia = _context.SosialMedias.ToList();
            foreach (var item in sosialMedia)
            {
                Console.WriteLine(item.Id);
            }
            return View(sosialMedia);
        }

        
    }
}
