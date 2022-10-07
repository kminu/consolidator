namespace Common.Library.DataAccess
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters);
        Task<int> SaveData<T>(string storedProcedure, T parameters);
        void StartTransaction();
        Task<List<T>> LoadDataInTransaction<T, U>(string storedProcedure, U parameters);
        Task<int> SaveDataInTransaction<T>(string storedProcedure, T parameters);
        void CommitTransaction();
        void RollbackTransaction();
        void Dispose();
    }
}