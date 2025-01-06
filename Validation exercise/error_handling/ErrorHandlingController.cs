using Microsoft.AspNetCore.Mvc;
using System;

namespace error_handling.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorHandlingController : ControllerBase
    {
        [HttpGet("divide")]
        public IActionResult DivideNumbers(int a, int b)
        {
            try
            {
                if (b == 0)
                    throw new DivideByZeroException("Division by zero is not allowed.");

                int result = a / b;
                return Ok(new { Result = result });
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("fetch")]
        public IActionResult FetchData()
        {
            try
            {
                // Simulate data fetching
                throw new Exception("Unexpected error while fetching data.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }
    }
}
