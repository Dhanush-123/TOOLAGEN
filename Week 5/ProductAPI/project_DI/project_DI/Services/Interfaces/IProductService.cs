using project_DI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace project_DI.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
    }
}
