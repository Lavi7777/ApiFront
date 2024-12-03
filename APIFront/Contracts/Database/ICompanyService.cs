using APIFront.Models.Database;

namespace APIFront.Contracts.Database
{
    public interface ICompanyService
    {
        Task CreateAsync(Company company);
        Task UpdateAsync(string id, Company company);
        Task<List<Company>> GetAsync();
    }
}
