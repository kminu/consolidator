using TTracker.Library.Models;

namespace TTracker.Library.Data
{
    public interface IUserData
    {
        Task CreatePerson(UserModel user);
        Task<List<UserModel>> GetPerson_All();
        Task UpdatePerson(UserModel user);
    }
}