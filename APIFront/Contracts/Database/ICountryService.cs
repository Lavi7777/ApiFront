using APIFront.Models.Database;

namespace APIFront.Contracts.Database
{
    public interface ICountryService
    {
        public Task CreateAsync(Country country);

        public Task UpdateAsync(string id, Country country);

        public Task<List<Country>> GetAsync();
        
    }
}
