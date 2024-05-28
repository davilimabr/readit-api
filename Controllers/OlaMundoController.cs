using Microsoft.AspNetCore.Mvc;

namespace readit.API.Controllers
{
    [ApiController]
    [Route("api/{versao}/[controller]")]
    public class OlaMundoController : ControllerBase
    {
        private readonly ILogger<OlaMundoController> _logger;

        public OlaMundoController(ILogger<OlaMundoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Olá mundo!");
        }
    }
}
