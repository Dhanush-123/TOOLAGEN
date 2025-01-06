using Microsoft.AspNetCore.Mvc;
using dependency_injection.Services;

namespace dependency_injection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsyncProductController : ControllerBase
    {
        private readonly IAsyncProductService _asyncProductService;

        public AsyncProductController(IAsyncProductService asyncProductService)
        {
            _asyncProductService = asyncProductService;
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> GetProductDetails(int id)
        {
            var details = await _asyncProductService.GetProductDetailsAsync(id);
            return Ok(details);
        }
    }
}
