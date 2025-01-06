using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PostRequest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // Mocked product database
        private static readonly List<Product> ProductsDatabase = new();

        // POST: api/products/add
        [HttpPost("add")]
        public IActionResult AddProducts([FromBody] List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                return BadRequest(new { Message = "No products provided." });
            }

            var duplicateProducts = products.Where(p => ProductsDatabase.Any(db => db.Id == p.Id || db.Name == p.Name)).ToList();

            if (duplicateProducts.Any())
            {
                return Conflict(new
                {
                    Message = "Some products already exist.",
                    Duplicates = duplicateProducts
                });
            }

            int initialCount = ProductsDatabase.Count;

            // Add products to the mock database
            ProductsDatabase.AddRange(products);

            int addedCount = ProductsDatabase.Count - initialCount;

            return Ok(new
            {
                Message = $"{addedCount} products were added successfully.",
                TotalProducts = ProductsDatabase.Count
            });
        }
    }

    // Product model
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
