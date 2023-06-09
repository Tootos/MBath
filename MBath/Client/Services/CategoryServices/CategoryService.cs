using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace MBath.Client.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public event Action CategoriesChanged;

        public List<Category> Categories { get; set; }= new List<Category>();
        public string Message { get; set; } = "Loading. . .";

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>($"api/category");

            return result;
            
            
        }

        public async Task GetCategoriesAsync(string categoryUrl)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>($"api/category/{categoryUrl}");
            if(result != null && result.Data!=null) 
            {
                 Categories= result.Data;
            }
            CategoriesChanged.Invoke();
        }

        public async Task GetParentCategoriesAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>($"api/category/parents");
            if (result != null && result.Data != null)
            {
                Categories = result.Data;
            }
            CategoriesChanged.Invoke();
        }
    }
}
