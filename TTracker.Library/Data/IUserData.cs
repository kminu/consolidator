using TTracker.Library.Models;

namespace TTracker.Library.Data
{
    public interface IUserData
    {
        Task CreatePerson(UserModel user);
        Task<List<UserModel>> GetPerson_All();
        Task<UserModel> GetPerson_ById(int userId);
        

        Task UpdatePerson(UserModel user);
    }
}