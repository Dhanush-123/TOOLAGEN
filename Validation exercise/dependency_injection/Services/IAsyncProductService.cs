namespace dependency_injection.Services
{
    public interface IAsyncProductService
    {
        Task<string> GetProductDetailsAsync(int id);
    }
}
