using MBath.Shared.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace MBath.Client.Services.CategoryService
{
    public class CategorySrvc : ICategorySrvc
    {
        private readonly HttpClient _http;
        private readonly IProductSrvc _productService;

        public event Action CategoriesChanged;

        public List<Category> Categories { get; set; } = new List<Category>();
        public string Message { get; set; } = "Loading. . .";
        public List<Category> AdminCategories { get; set; }= new List<Category>();

        public CategorySrvc(HttpClient http, IProductSrvc productService)
        {
            _http = http;
            _productService = productService;
        }


        public async Task GetCategoriesAsync()
        {
            
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");

            if (result != null && result.Data != null)
            {
                Categories = result.Data;
            }           
        }

        public List<Category> ShowCategoriesByUrl(string? categoryUrl = null)
        {
            var result= new List<Category>();

            if(categoryUrl== null)
            {
                result= Categories.Where(c=>c.ParentId==0).ToList();
                return result;
            }

            var parentId =  Categories.Find(c => c.Url.ToLower().Contains(categoryUrl.ToLower())).Id;

            if(Categories != null && Categories.Count!= 0)
            {
                result = Categories.Where(c=>c.ParentId==parentId).ToList();
            }

            return result;
        }

        public async Task GetAdminCategoriesAsync()
        {

            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category/admin");

            if (result != null && result.Data != null)
            {
                AdminCategories = result.Data;
            }
        }

        

        public async Task AddCategoryAsync(Category category)
        {
            var result= await _http.PostAsJsonAsync("api/category/admin",category);
            if(result != null)
            {
                AdminCategories = (await result.Content
                    .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
                await GetCategoriesAsync();
                CategoriesChanged.Invoke();
            }

        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            var result = await _http.DeleteAsync($"api/category/admin/{categoryId}");
            if (result != null)
            {
                AdminCategories = (await result.Content
                    .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
                await GetCategoriesAsync();
                CategoriesChanged.Invoke();
            }
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            var result = await _http.PutAsJsonAsync("api/category/admin", category);
            if (result != null)
            {
                AdminCategories = (await result.Content
                    .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
                await GetCategoriesAsync();
                CategoriesChanged.Invoke();
            }
        }

        public Category CreateNewCategory()
        {
            var newCategory= new Category() { IsNew = true, Editing=true };
            AdminCategories.Add(newCategory);
            CategoriesChanged.Invoke();
            return newCategory;
        }

        public List<Category> GetCategoriesWithProducts()
        {
            return AdminCategories.Where(c=>c.HasProducts).ToList();
        }
    }
}
