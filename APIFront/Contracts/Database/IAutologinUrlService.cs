using APIFront.Models.Database.AffiliateCampaign;
using APIFront.Services.Database;

namespace APIFront.Contracts.Database
{
    public interface IAutologinUrlService
    {
        Task CreateAsync(AutologinUrl autologin);
        Task UpdateAsync(string id, AutologinUrl autologin);
        Task<List<AutologinUrl>> GetAsync();
    }
}
