using APIFront.Contracts.Database;
using APIFront.Models.Shared;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Linq.Expressions;

namespace APIFront.Services.Database
{
    public class MongoDbService: IMongoDbService
    {
        private readonly IMongoDatabase _database;

        public MongoDbService(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
            _database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
        }

        private IMongoCollection<T> GetCollection<T>()
        {
            return _database.GetCollection<T>(typeof(T).Name);
        }

        public Task<List<T>> Find<T>()
        {
            return GetCollection<T>().AsQueryable().ToListAsync();
        }

        public Task AddAsync<T>(T model)
        {
            return GetCollection<T>().InsertOneAsync(model);
        }

        public async Task<bool> UpdateByIdAsync<T>(string id, T model)
        {
            return (await GetCollection<T>().ReplaceOneAsync(Builders<T>.Filter.Eq("Id", id), model)).ModifiedCount > 0;
        }

        
        }
}
