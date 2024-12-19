using project_DI.Models;
using project_DI.Repositories.Interfaces;
using project_DI.Services.Interfaces;

namespace project_DI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);

            if (product == null)
            {
                Console.WriteLine($"Product with ID {id} not found.");  // Log the issue
            }

            return product;
        }
    }

}
