using Microsoft.AspNetCore.Mvc;
using nvctask.Data;

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
            return View();
        }

        
    }
}
