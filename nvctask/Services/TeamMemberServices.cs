using Microsoft.EntityFrameworkCore;
using nvctask.Data;
using nvctask.Models;
using nvctask.Services.Interface;

namespace nvctask.Services
{
    public class TeamMemberServices : ITeamMemberServices
    {
        private readonly AppDbContext _context;


        public TeamMemberServices(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<List<TeamMember>> GetAllTeamMembersAsync()
        {
            var teamMembers = await _context.TeamMembers.Include(tm => tm.SosialMedias).ToListAsync();
            return teamMembers;
        }
    }
}
