

namespace MBath.Server.Services.CategoryServices
{
    public interface ICategorySrvc
    {      
        Task<ServiceResponse<List<Category>>> GetCategoriesAsync();
        Task<ServiceResponse<Category>> GetCategoryParentAsync(int parentId);
        Task<ServiceResponse<List<Category>>> GetParentCategoriesAsync();
        Task<ServiceResponse<List<Category>>> GetCategoriesAsync(string categoryURL);        
        Task<ServiceResponse<bool>> DoesCategoryHaveProductsAsync(int categoryId);
    }
}
