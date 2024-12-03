using APIFront.Contracts.Database;
using APIFront.Models.Database;

namespace APIFront.Services.Database
{
    public class CompanyService:ICompanyService
    {
        private readonly IMongoDbService _databaseService;
        public CompanyService(IMongoDbService databaseService)
        {
            _databaseService = databaseService;
        }
        public Task CreateAsync(Company company)
        {
            return _databaseService.AddAsync(company);
        }
        public Task UpdateAsync(string id, Company company)
        {
            return _databaseService.UpdateByIdAsync(id, company);
        }
        public Task<List<Company>> GetAsync()
        {
            return _databaseService.Find<Company>();
        }
    }
}
