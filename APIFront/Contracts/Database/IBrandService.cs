using APIFront.Models.Database;

namespace APIFront.Contracts.Database
{
    public interface IBrandService
    {
        Task CreateAsync(Brand brand);

        Task UpdateAsync(string id, Brand brand);

        Task<List<Brand>> GetAsync();
        
    }
}
