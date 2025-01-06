using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingLINQAndCollections.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        // Static list for users
        private static readonly List<User> Users = new()
        {
            new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
            new User { Id = 2, Name = "Bob", Email = "bob@example.com" },
            new User { Id = 3, Name = "Charlie", Email = "charlie@example.com" }
        };

        // Sample list of products
        private readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Phone", Price = 500 },
            new Product { Id = 3, Name = "Tablet", Price = 700 }
        };

        // Endpoint to filter and sort products
        [HttpGet("products")]
        public IActionResult GetFilteredProducts([FromQuery] string filter, [FromQuery] string sortBy = "Name")
        {
            try
            {
                var query = Products.AsQueryable();

                // Apply filtering
                if (!string.IsNullOrEmpty(filter))
                {
                    query = query.Where(p => p.Name.Contains(filter, StringComparison.OrdinalIgnoreCase));
                }

                // Apply sorting
                query = sortBy.ToLower() switch
                {
                    "price" => query.OrderBy(p => p.Price),
                    _ => query.OrderBy(p => p.Name)
                };

                return Ok(query.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // Endpoint to retrieve the user list
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            try
            {
                if (Users == null || !Users.Any())
                {
                    return NotFound("No users found.");
                }

                return Ok(Users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }


}
