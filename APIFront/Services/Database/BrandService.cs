using APIFront.Contracts.Database;
using APIFront.Models.Database;

namespace APIFront.Services.Database
{
    public class BrandService:IBrandService
    {
        private readonly IMongoDbService _databaseService;
        public BrandService(IMongoDbService databaseService)
        {
            _databaseService = databaseService;
        }

        public Task CreateAsync(Brand brand)
        {
            return _databaseService.AddAsync(brand);
        }
        public Task UpdateAsync(string id, Brand brand)
        {
            return _databaseService.UpdateByIdAsync(id, brand);
        }
        public Task<List<Brand>> GetAsync()
        {
            return _databaseService.Find<Brand>();
        }
    }
}
