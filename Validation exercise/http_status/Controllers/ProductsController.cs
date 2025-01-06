using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace http_status.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Console.WriteLine($"Received request for product ID: {id}");

            var products = new List<string> { "Computer", "Table", "Monitor" };

            if (id <= 0)
            {
                return BadRequest(new { Message = "Invalid product ID provided." });
            }

            if (id > products.Count)
            {
                return NotFound(new { Message = "Product not found." });
            }

            var product = products[id - 1];
            return Ok(new { Product = product });
        }
    }
}
