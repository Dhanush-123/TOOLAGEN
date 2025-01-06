namespace dependency_injection.Services
{
    public class AsyncProductService : IAsyncProductService
    {
        public Task<string> GetProductDetailsAsync(int id)
        {
            return Task.FromResult($"Product details for ID: {id}");
        }
    }
}
