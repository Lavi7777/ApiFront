using APIFront.Contracts.Database;
using APIFront.Models.Database.AffiliateCampaign;
using MongoDB.Driver.Linq;

namespace APIFront.Services.Database
{
    
    public class AffiliateCampaignService: IAffiliateCampaignService
    {
        private readonly IMongoDbService _databaseService;
        public AffiliateCampaignService(IMongoDbService databaseService)
        {
            _databaseService = databaseService;
        }

        public Task CreateAsync(AffiliateCampaign newAffiliate)
        {
            return _databaseService.AddAsync(newAffiliate);
        }
        public Task UpdateAsync(string id, AffiliateCampaign affiliate)
        {
            return _databaseService.UpdateByIdAsync(id,affiliate);
        }
        public Task<List<AffiliateCampaign>> GetAsync()
        {
            return _databaseService.Find<AffiliateCampaign>();
        }
    }
}
