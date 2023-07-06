

namespace MBath.Server.Services.CategoryServices
{
    public interface ICategorySrvc
    {
        Task<ServiceResponse<List<Category>>> GetCategoriesAsync();

        Task<ServiceResponse<List<Category>>> GetAdminCategoriesAsync();

        Task<ServiceResponse<List<Category>>> AddCategoriesAsync(Category category);

        Task<ServiceResponse<List<Category>>> UpdateCategoriesAsync(Category category);
        Task<ServiceResponse<List<Category>>> DeleteCategoryAsync(int id);
            
        Task<ServiceResponse<bool>> HasProductsAsync(int categoryId);
    }
}
