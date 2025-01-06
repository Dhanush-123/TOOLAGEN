using System;
using System.Collections.Generic;
using CombiningLearning.Models;


namespace CombiningLearning.Services
{
    public interface IProductService
    {
        IEnumerable<Product> ApplyDiscount(Func<Product, decimal> discountCalculator);
        IEnumerable<Product> FilterProducts(decimal priceThreshold);
    }
}