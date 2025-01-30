using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTradingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        public StockController()
        {
        }

        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok();
        }
    }
}
