using APIFront.Contracts.Database;
using APIFront.Models.Database.AffiliateCampaign;

namespace APIFront.Services.Database
{
    public class AutologinUrlService: IAutologinUrlService
    {
        private readonly IMongoDbService _databaseService;
        public AutologinUrlService(IMongoDbService databaseService)
        {
            _databaseService = databaseService;
        }

        public Task CreateAsync(AutologinUrl autologin)
        {
            return _databaseService.AddAsync(autologin);
        }
        public Task UpdateAsync(string id, AutologinUrl autologin)
        {
            return _databaseService.UpdateByIdAsync(id, autologin);
        }
        public Task<List<AutologinUrl>> GetAsync()
        {
            return _databaseService.Find<AutologinUrl>();
        }
    }
}
