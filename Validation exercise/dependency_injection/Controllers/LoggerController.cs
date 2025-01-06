using Microsoft.AspNetCore.Mvc;
using dependency_injection.Services;

namespace dependency_injection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoggerController : ControllerBase
    {
        private readonly ILoggerService _loggerService;

        public LoggerController(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        [HttpGet("log/{message}")]
        public IActionResult LogMessage(string message)
        {
            return Ok(_loggerService.Log(message));
        }
    }
}
