using APIFront.Contracts.Database;
using APIFront.Models.Database;
using APIFront.Models.Database.AffiliateCampaign;
using Microsoft.AspNetCore.Mvc;

namespace APIFront.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutologinUrlController:ControllerBase
    {
        private readonly IAutologinUrlService _autologinUrlService;

        public AutologinUrlController(IAutologinUrlService autologinUrlService)
        {
            _autologinUrlService = autologinUrlService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AutologinUrl autologin)
        {

            await _autologinUrlService.CreateAsync(autologin);
            return Ok(autologin);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<AutologinUrl> autologinList = await _autologinUrlService.GetAsync();
            return Ok(autologinList.AsQueryable().ToDictionary(id => id.Id, name => name.Description));
        }
    }
}
