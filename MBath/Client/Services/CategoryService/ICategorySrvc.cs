namespace MBath.Client.Services.CategoryService
{
    public interface ICategorySrvc
    {
        string Message { get; set; }
        event Action CategoriesChanged; 
        List<Category> Categories { get; set; }

        List<Category> AdminCategories { get; set; }
    
        Task GetCategoriesAsync();

        Task GetAdminCategories();
        Task AddCategory(Category category);
        Task DeleteCategory(int categoryId);
        Task UpdateCategory(Category category);

        Category CreateNewCategory();

        List<Category> ShowCategoriesByUrl(string? categoryUrl); 



    }
}
