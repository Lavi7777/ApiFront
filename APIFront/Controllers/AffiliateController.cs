using APIFront.Contracts.Database;
using APIFront.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace APIFront.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AffiliateController:ControllerBase
    {
        private readonly IAffiliateService _affiliateService;

        public AffiliateController(IAffiliateService affiliateService)
        {
            _affiliateService = affiliateService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Affiliate newAffiliate)
        {
         
            await _affiliateService.CreateAsync(newAffiliate);
            return Ok(newAffiliate);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<Affiliate> affList = await _affiliateService.GetAsync();
            return Ok(affList.AsQueryable().ToDictionary(id=>id.Id,name=>name.AffiliateName));
        }
    }
}
