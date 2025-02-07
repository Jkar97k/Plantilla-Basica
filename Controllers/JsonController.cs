using api_basica.Interfaces.http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_basica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {
        private readonly IPostHttpService _postHttpService;

        public JsonController([FromKeyedServices("PostServices")]IPostHttpService postHttpService)
        {
            _postHttpService = postHttpService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var datos = await _postHttpService.Gethttp();

            return Ok(datos);
        }
    }
}
