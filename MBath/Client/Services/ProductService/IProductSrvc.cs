namespace MBath.Client.Services.ProductService
{
    public interface IProductSrvc
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        List<Product> AdminProducts { get; set; }

        string Message { get; set; }
        int CurrentPage { get; set; }
        int Pages { get; set; } 
        bool IsSearchPage { get; set; }

        string LastSearchedText { get; set; } 
        Task GetProductsAsync(string categoryUrl,int page);

        Task<ServiceResponse<Product>> GetProductAsync(int productId);

        Task SearchProductsAsync(string searchedText, int page);
        Task<List<string>> GetProductSuggestions(string searchedText);

        Task GetAdminProductsAsync();

        Task<Product> AddProductAsync(Product product);

        Task<Product> UpdateProductAsync(Product product);

        Task DeleteProductAsync(int productId);
    }
}
