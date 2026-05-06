using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nvctask.Data;
using System.Threading.Tasks;

namespace nvctask.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }
    }
}
