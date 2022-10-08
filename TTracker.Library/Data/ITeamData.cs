using TTracker.Library.Models;

namespace TTracker.Library.Data
{
    public interface ITeamData
    {
        void CreateTeam(TeamModel team);
        Task<List<TeamModel>> GetTeam_All();
    }
}