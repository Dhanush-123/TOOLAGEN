using Microsoft.AspNetCore.Mvc;

namespace BasicWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // In-memory list of products for testing purposes
        private static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500.00m, Description = "A high-performance laptop" },
            new Product { Id = 2, Name = "Headphones", Price = 100.00m, Description = "Noise-cancelling headphones" }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
