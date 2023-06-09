using MBath.Client.Pages;

using System.Net.Http.Json;

namespace MBath.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public string Message { get; set; } = "Loading. . .";
        public List<Product> Products { get; set; }= new List<Product>();

        public int CurrentPage { get; set; } = 1;
        public int Pages { get; set; } = 0;
        public bool IsSearchPage { get; set; } = false;

        public string LastSearchedText { get; set; } = string.Empty;

        public event Action ProductsChanged;

        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http=http;
        }
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{productId}");
            
            if(result == null || result.Data==null)
            {
                result.Success= false;
                result.Message = "Product not found";
               
            }
            
            return result;
    
        }

        public async Task GetProductsAsync(string categoryUrl , int page)
        {
            LastSearchedText = categoryUrl;

            var result =  
                await _http.GetFromJsonAsync<ServiceResponse<ProductListResponse>>($"api/Product/products/{categoryUrl}/{page}");

            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                Pages = result.Data.Pages;
            }

           

            ProductsChanged.Invoke();
        }

        public async Task SearchProductsAsync(string searchedText, int page)
        {
            LastSearchedText = searchedText;
            var result = 
                await _http.GetFromJsonAsync<ServiceResponse<ProductListResponse>>($"api/Product/search/{searchedText}/{page}");
            
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage= result.Data.CurrentPage;
                Pages= result.Data.Pages;
            }

            if (Products.Count == 0)
            {
                Message = "No products were found!";
            }
            ProductsChanged.Invoke();
        }

        public async Task<List<string>> GetProductSuggestions(string searchedText)
        {
            var result = await _http.
                GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchedText}");
            return result.Data;
        }
    }
}
