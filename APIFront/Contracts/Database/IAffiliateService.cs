using APIFront.Models.Database;

namespace APIFront.Contracts.Database
{
    public interface IAffiliateService
    {
        Task CreateAsync(Affiliate newAffiliate);

        Task UpdateAsync(string id, Affiliate affiliate);
        
        Task<List<Affiliate>> GetAsync();
        
    }
}
