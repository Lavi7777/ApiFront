using APIFront.Contracts.Database;
using APIFront.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace APIFront.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CompanyController:ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Company company)
        {

            await _companyService.CreateAsync(company);
            return Ok(company);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<Company> countryList = await _companyService.GetAsync();
            return Ok(countryList.AsQueryable().ToDictionary(id => id.Id, name => name.CompanyName));
        }
    }
}

