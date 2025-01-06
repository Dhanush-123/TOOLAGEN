using Microsoft.AspNetCore.Mvc;
using CombiningLearning.Services;
using CombiningLearning.Models;
using System;

namespace CombiningLearning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("discounted")] 
        public IActionResult GetDiscountedProducts([FromQuery] decimal discountPercentage)
        {
            if (discountPercentage <= 0 || discountPercentage >= 100)
            {
                return BadRequest("Discount percentage must be between 1 and 99.");
            }

            Func<Product, decimal> discountCalculator = product => product.Price - (product.Price * discountPercentage / 100);
            var discountedProducts = _productService.ApplyDiscount(discountCalculator);

            return Ok(discountedProducts);
        }

        [HttpGet("filtered")] 
        public IActionResult GetFilteredProducts([FromQuery] decimal priceThreshold)
        {
            if (priceThreshold <= 0)
            {
                return BadRequest("Price threshold must be greater than 0.");
            }

            var filteredProducts = _productService.FilterProducts(priceThreshold);

            return Ok(filteredProducts);
        }
    }
}