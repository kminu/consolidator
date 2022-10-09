using System.Data;
using Dapper;
using System.Reflection;
using System.Xml;
using TTracker.Library.Models;
using Common.Library.DataAccess;

namespace TTracker.Library.Data;

public class UserData : IUserData
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
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        return _dataAccess.SaveData("dbo.spPeople_Insert", p);
    }

    public async Task<List<UserModel>> GetPerson_All()
    {
        return await _dataAccess.LoadData<UserModel, dynamic>("dbo.spPeople_GetAll", new { });
    }

    public async Task<UserModel> GetPerson_ById(int userId)
    {
        var output = await _dataAccess.LoadData<UserModel, dynamic>("dbo.spPeople_GetById",
                                                                    new { id = userId});
        return output.FirstOrDefault();
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