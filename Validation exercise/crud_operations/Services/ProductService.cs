using crud_operations.Models;
using System.Collections.Generic;
using System.Linq;

namespace crud_operations.Services
{
    public class ProductService
    {
        private static List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000, Quantity = 10 },
            new Product { Id = 2, Name = "Phone", Price = 20000, Quantity = 15 }
        };

        public List<Product> GetAllProducts() => _products;

        // public Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);
        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);


        public void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public bool UpdateProduct(int id, Product updatedProduct)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Quantity = updatedProduct.Quantity;
            return true;
        }

        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;

            _products.Remove(product);
            return true;
        }
    }
}
