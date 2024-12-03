using APIFront.Models.Database.AffiliateCampaign;

namespace APIFront.Contracts.Database
{
    public interface IAffiliateCampaignService
    {
        Task CreateAsync(AffiliateCampaign newAffiliate);

        Task UpdateAsync(string id, AffiliateCampaign affiliate);

        Task<List<AffiliateCampaign>> GetAsync();
        
    }
}
