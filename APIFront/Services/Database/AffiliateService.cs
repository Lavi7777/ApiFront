using APIFront.Contracts.Database;
using APIFront.Models.Database;
using MongoDB.Driver.Linq;


namespace APIFront.Services.Database
{
    public class AffiliateService:IAffiliateService
    {
        private readonly IMongoDbService _databaseService;
        public AffiliateService(IMongoDbService databaseService)
        {
            _databaseService = databaseService;
        }

        public Task CreateAsync(Affiliate newAffiliate)
        {
            return _databaseService.AddAsync(newAffiliate);
        }
        public Task UpdateAsync(string id, Affiliate affiliate)
        {
            return _databaseService.UpdateByIdAsync(id, affiliate);
        }
        public Task<List<Affiliate>> GetAsync()
        {
            return _databaseService.Find<Affiliate>();
        }
    }
}
