// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using System.Linq;

// [ApiController]
// [Route("api/[controller]")]
// public class CarProductsController : ControllerBase
// {
//    private static List<CarProduct> carProducts = new List<CarProduct>
// {
//         new CarProduct { Id = 1, Name = "Kia", Category = "Offroad", Price = 20000 },
//         new CarProduct { Id = 2, Name = "Honda", Category = "Luxury", Price = 30000 },
//         new CarProduct { Id = 3, Name = "Hyundai", Category = "Offroad", Price = 28000 },
//         new CarProduct { Id = 4, Name = "TATA", Category = "Luxury", Price = 43000 },
//         new CarProduct { Id = 5, Name = "toyota", Category = "Economy", Price = 15000 }
// };


//   [HttpGet]
// public ActionResult<IEnumerable<CarProduct>> Get([FromQuery] string category, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
// {
//     var filteredProducts = carProducts.AsQueryable();

//     if (!string.IsNullOrEmpty(category))
//     {
//         filteredProducts = filteredProducts.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
//     }

//     if (minPrice.HasValue)
//     {
//         filteredProducts = filteredProducts.Where(p => p.Price >= minPrice.Value);
//     }

//     if (maxPrice.HasValue)
//     {
//         filteredProducts = filteredProducts.Where(p => p.Price <= maxPrice.Value);
//     }

//     return Ok(filteredProducts.ToList());
// }

// }



using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class CarProductsController : ControllerBase
{
    // Sample data
    private static List<CarProduct> carProducts = new List<CarProduct>
    {
        new CarProduct { Id = 1, Name = "Kia", Category = "Offroad", Price = 20000 },
        new CarProduct { Id = 2, Name = "Honda", Category = "Luxury", Price = 30000 },
        new CarProduct { Id = 3, Name = "Hyundai", Category = "Offroad", Price = 28000 },
        new CarProduct { Id = 4, Name = "TATA", Category = "Luxury", Price = 43000 },
        new CarProduct { Id = 5, Name = "toyota", Category = "Economy", Price = 15000 }
    };

    // Get method to filter by price range
    [HttpGet]
    public ActionResult<IEnumerable<CarProduct>> Get([FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
    {
        // Start with all car products
        var filteredProducts = carProducts.AsQueryable();
        // Apply filters if provided
 
        if (minPrice.HasValue)
        {
            filteredProducts = filteredProducts.Where(p => p.Price >= minPrice.Value);
        }

        if (maxPrice.HasValue)
        {
            filteredProducts = filteredProducts.Where(p => p.Price <= maxPrice.Value);
        }

        return Ok(filteredProducts.ToList());
    }
}
