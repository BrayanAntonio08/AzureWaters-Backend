using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AW_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Preuba()
        {
            return await Task.FromResult(Ok("Hellos"));
        }
    }
}
