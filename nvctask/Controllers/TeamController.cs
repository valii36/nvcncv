using Microsoft.AspNetCore.Mvc;
using nvctask.Data;
using nvctask.Models;
using System.Diagnostics;

namespace nvctask.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TeamController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var teamMembers =  _appDbContext.TeamMembers.ToList();
            return View(teamMembers);
        }

    }
}