using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BikeProductsController : ControllerBase
{
    // Sample data for demonstration purposes
    private static readonly List<BikeProduct> BikeProducts = new List<BikeProduct>
    {
        new BikeProduct { Id = 1, Name = "Mountain Bike", Price = 15000 },
        new BikeProduct { Id = 2, Name = "Road Bike", Price = 12000 },
        new BikeProduct { Id = 3, Name = "Hybrid Bike", Price = 10000 }
    };

    // GET api/bikeproducts/{id}
    [HttpGet("{id:int}")]
    public ActionResult<BikeProduct> GetBikeProductById(int id)
    {
        var bikeProduct = BikeProducts.FirstOrDefault(bp => bp.Id == id);

        if (bikeProduct == null)
        {
            return NotFound(new { Message = $"BikeProduct with ID {id} not found." });
        }

        return Ok(bikeProduct);
    }
}

// BikeProduct model
public class BikeProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}
