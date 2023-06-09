using MBath.Shared.Models;

namespace MBath.Server.Services.CategoryServices
{
    public interface ICategoryService
    {      
        Task<ServiceResponse<List<Category>>> GetCategories();
        Task<ServiceResponse<Category>> GetCategoryParent(int parentId);
        Task<ServiceResponse<List<Category>>> GetParentCategories();

        Task<ServiceResponse<List<Category>>> GetCategories(string categoryURL);
        
        Task<bool> DoesCategoryHaveProducts(int categoryID);//To be removed
    }
}
