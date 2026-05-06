using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nvctask.Data;
using nvctask.Models;
using nvctask.Services.Interface;
using System.Diagnostics;

namespace nvctask.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamMemberServices _teamMemberServices;

        public TeamController(ITeamMemberServices teamMemberServices)
        {
            _teamMemberServices = teamMemberServices;
        }

        public async Task<IActionResult> Index()
        {
            var teamMember = await _teamMemberServices.GetAllTeamMembersAsync();
            return View(teamMember);
        }

    }
}