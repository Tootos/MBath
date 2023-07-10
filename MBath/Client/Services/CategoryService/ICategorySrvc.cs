namespace MBath.Client.Services.CategoryService
{
    public interface ICategorySrvc
    {
        string Message { get; set; }
        event Action CategoriesChanged; 
        List<Category> Categories { get; set; }

        List<Category> AdminCategories { get; set; }
    
        Task GetCategoriesAsync();

        Task GetAdminCategoriesAsync();

        List<Category> GetCategoriesWithProducts();
        Task AddCategoryAsync(Category category);
        Task DeleteCategoryAsync(int categoryId);
        Task UpdateCategoryAsync(Category category);

        Category CreateNewCategory();

        List<Category> ShowCategoriesByUrl(string? categoryUrl); 



    }
}
