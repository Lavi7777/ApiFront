using APIFront.Contracts.Database;
using APIFront.Models.Database;

namespace APIFront.Services.Database
{
    public class CountryService:ICountryService
    {
        private readonly IMongoDbService _databaseService;
        public CountryService(IMongoDbService databaseService)
        {
            _databaseService = databaseService;
        }
        public Task CreateAsync(Country country)
        {
            return _databaseService.AddAsync(country);
        }
        public Task UpdateAsync(string id, Country country)
        {
            return _databaseService.UpdateByIdAsync(id, country);
        }
        public Task<List<Country>> GetAsync()
        {
            return _databaseService.Find<Country>();
        }
    }
}

