using Common.Library.DataAccess;
using Dapper;
using System.Data;
using System.Reflection;
using TTracker.Library.Models;

namespace TTracker.Library.Data;

public class PrizeData : IPrizeData
{
    private readonly IDataAccess _dataAccess;

    public PrizeData(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public Task CreatePrize(PrizeModel prize)
    {
        var p = new DynamicParameters();
        p.Add("@PlaceNumber", prize.PlaceNumber);
        p.Add("@PlaceName", prize.PlaceName);
        p.Add("@PrizeAmount", prize.PrizeAmount);
        p.Add("@PrizePercentage", prize.PrizePercentage);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        return _dataAccess.SaveData("dbo.spPrizes_Insert", p);
    }

    public Task<List<PrizeModel>> GetPrize_All()
    {
        return _dataAccess.LoadData<PrizeModel, dynamic>("dbo.spPrizes_GetAll", new { });
    }
}