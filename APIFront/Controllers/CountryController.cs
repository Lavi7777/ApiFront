using APIFront.Contracts.Database;
using APIFront.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace APIFront.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CountryController:ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Country country)
        {

            await _countryService.CreateAsync(country);
            return Ok(country);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<Country> countryList = await _countryService.GetAsync();
            return Ok(countryList.AsQueryable().ToDictionary(id => id.Id, name => name.CountryName));
        }
    }
}
