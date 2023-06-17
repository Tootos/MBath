namespace MBath.Client.Services.CategoryServices
{
    public interface ICategorySrvc
    {
        string Message { get; set; }
        event Action CategoriesChanged; 
        List<Category> Categories { get; set; }

        Task<ServiceResponse<List<Category>>> GetCategoriesAsync();       
        Task GetCategoriesAsync(string categoryUrl);

        Task<bool> HasProductsAsync(int categoryId);
        Task GetParentCategoriesAsync();
       



    }
}
