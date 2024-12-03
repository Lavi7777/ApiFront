namespace APIFront.Contracts.Database
{
    public interface IMongoDbService
    {
        Task<List<T>> Find<T>();
        Task AddAsync<T>(T model);
        Task<bool> UpdateByIdAsync<T>(string id, T model);
    }
}
