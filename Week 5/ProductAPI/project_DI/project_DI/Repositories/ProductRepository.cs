using project_DI.Models;
using Microsoft.EntityFrameworkCore;
using project_DI.Repositories.Interfaces;
using ProjectName.Data;

namespace project_DI.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id); // FindAsync works for SQL Server as well
        }
    }



}
