using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_core_web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return Random.Shared.Next();
        }
    }
}
