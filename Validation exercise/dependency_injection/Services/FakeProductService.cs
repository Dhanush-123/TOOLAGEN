namespace dependency_injection.Services
{
    public class FakeProductService : IProductService
    {
        public IEnumerable<string> GetProducts()
        {
            return new List<string> { "Laptop", "Smartphone", "Tablet" };
        }
    }
}
