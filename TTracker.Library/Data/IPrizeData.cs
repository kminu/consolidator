using TTracker.Library.Models;

namespace TTracker.Library.Data
{
    public interface IPrizeData
    {
        Task CreatePrize(PrizeModel prize);
        Task<List<PrizeModel>> GetPrize_All();
    }
}