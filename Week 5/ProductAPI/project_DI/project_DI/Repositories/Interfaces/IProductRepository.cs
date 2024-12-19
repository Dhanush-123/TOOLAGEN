using project_DI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace project_DI.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
    }
}
