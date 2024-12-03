using APIFront.Contracts.Database;
using APIFront.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace APIFront.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BrandController: ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Brand brand)
        {

            await _brandService.CreateAsync(brand);
            return Ok(brand);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<Brand> affList = await _brandService.GetAsync();
            return Ok(affList.AsQueryable().ToDictionary(id => id.Id, name => name.BrandName));
        }
    }
}
