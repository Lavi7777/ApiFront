using APIFront.Contracts.Database;
using APIFront.Models.Database.AffiliateCampaign;
using Microsoft.AspNetCore.Mvc;

namespace APIFront.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AffiliateCampaignController:ControllerBase
    {
        private readonly IAffiliateCampaignService _affiliateCampaignService;

        public AffiliateCampaignController(IAffiliateCampaignService affiliateCampaignService)
        {
            _affiliateCampaignService = affiliateCampaignService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AffiliateCampaign newAffiliate)
        {

            await _affiliateCampaignService.CreateAsync(newAffiliate);
            return Ok(newAffiliate);
        }

        [HttpPut]
        public async Task<IActionResult> Update(string id,[FromBody] AffiliateCampaign newAffiliate)
        {

            await _affiliateCampaignService.UpdateAsync(id,newAffiliate);
            return Ok(newAffiliate);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<AffiliateCampaign> affList = await _affiliateCampaignService.GetAsync();
            return Ok(affList.AsQueryable().ToList());
        }
    }
}
