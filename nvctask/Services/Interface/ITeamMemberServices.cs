using nvctask.Models;

namespace nvctask.Services.Interface
{
    public interface ITeamMemberServices
    {
        public Task<List<TeamMember>> GetAllTeamMembersAsync();
    }
}
