using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nvctask.Data;

namespace nvctask.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var portfolios = await _context.Portfolios.Include(p => p.Category).ToListAsync();
            return View(portfolios);
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0) return NotFound();

            var portfolio = await _context.Portfolios
                                          .Include(p => p.Category)
                                          .FirstOrDefaultAsync(p => p.Id == id);

            if (portfolio == null) return NotFound();

            return View(portfolio);
        }

    }
}
