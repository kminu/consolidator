using Dapper;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using Common.Library.DataAccess;
using TTracker.Library.Models;

namespace TTracker.Library.Data;

public class TeamData
{
    private readonly IDataAccess _dataAccess;

    public TeamData(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public void CreateTeam(TeamModel team)
    {
        try
        {
            _dataAccess.StartTransaction();

            var p = new DynamicParameters();
            p.Add("@TeamName", team.TeamName);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            _dataAccess.SaveDataInTransaction("dbo.spTeams_Insert", p);

            team.Id = p.Get<int>("@id");

            foreach (UserModel user in team.TeamMembers)
            {
                p = new DynamicParameters();
                p.Add("@TeamId", team.Id);
                p.Add("@PersonId", user.Id);

                _dataAccess.SaveDataInTransaction("dbo.spTeamMembers_Insert", p);
            }
            _dataAccess.CommitTransaction();
        }
        catch (Exception e)
        {
            throw new InvalidDataContractException("It fails");
        }

    }

    public Task<List<TeamModel>> GetTeam_All()
    {
        _dataAccess.LoadData<TeamModel, dynamic>("dbo.spTeam_GetAll", new { });
    }
}