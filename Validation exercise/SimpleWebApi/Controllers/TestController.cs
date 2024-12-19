using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello, yaa now its working " });
        }

        [HttpGet("error")]
        public IActionResult Error()
        {
            throw new Exception("This is a test exception!"); 
        }
    }
}
