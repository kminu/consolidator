using System.Data;
using Dapper;
using System.Reflection;
using TTracker.Library.Models;
using Common.Library.DataAccess;

namespace TTracker.Library.Data;

public class UserData
{
    private readonly IDataAccess _dataAccess;

    public UserData(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public Task CreatePerson(UserModel user)
    {
        var p = new DynamicParameters();
        p.Add("@FirstName", user.FirstName);
        p.Add("@LastName", user.LastName);
        p.Add("@EmailAddress", user.EmailAddress);
        p.Add("@CellphoneNumber", user.CellphoneNumber);
        p.Add("@id",0,dbType:DbType.Int32, direction:ParameterDirection.Output);

        return _dataAccess.SaveData("dbo.spPeople_Insert", p);
    }

    public Task<List<UserModel>> GetPerson_All()
    {
        return _dataAccess.LoadData<UserModel, dynamic>("dbo.spPeople_GetAll", new { });
    }

    public Task UpdatePerson(UserModel user)
    {
        var p = new DynamicParameters();
        p.Add("@Id", user.Id);
        p.Add("@FirstName", user.FirstName);
        p.Add("@LastName", user.LastName);
        p.Add("@EmailAddress", user.EmailAddress);
        p.Add("@CellphoneNumber", user.CellphoneNumber);

        return _dataAccess.SaveData("dbo.spPeople_Update", p);
    }
}