using CombiningLearning.Models;

public interface IProductService
{
    IEnumerable<CombiningLearning.Models.Product> ApplyDiscount(Func<CombiningLearning.Models.Product, decimal> discountCalculator);
    IEnumerable<CombiningLearning.Models.Product> FilterProducts(decimal priceThreshold);
}

public class ProductService : IProductService
{
    private readonly List<CombiningLearning.Models.Product> _products;

    public ProductService()
    {
        _products = new List<CombiningLearning.Models.Product>
        {
            new CombiningLearning.Models.Product { Id = 1, Name = "Laptop", Price = 1200 },
            new CombiningLearning.Models.Product { Id = 2, Name = "Phone", Price = 800 },
            new CombiningLearning.Models.Product { Id = 3, Name = "Tablet", Price = 300 },
            new CombiningLearning.Models.Product { Id = 4, Name = "Monitor", Price = 150 }
        };
    }

    public IEnumerable<CombiningLearning.Models.Product> ApplyDiscount(Func<CombiningLearning.Models.Product, decimal> discountCalculator)
    {
        return _products.Select(product => new CombiningLearning.Models.Product
        {
            Id = product.Id,
            Name = product.Name,
            Price = discountCalculator(product)
        });
    }

    public IEnumerable<CombiningLearning.Models.Product> FilterProducts(decimal priceThreshold)
    {
        return _products.Where(product => product.Price > priceThreshold);
    }
}
