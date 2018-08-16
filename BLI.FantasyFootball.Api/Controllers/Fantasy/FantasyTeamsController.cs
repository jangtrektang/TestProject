using Microsoft.AspNetCore.Mvc;

namespace BLI.FantasyFootball.Api.Controllers.Fantasy
{
    [Route("api/[controller]")]
    [ApiController]
    public class FantasyTeamsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Dit is een test";
        }
    }
}