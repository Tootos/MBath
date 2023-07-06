

namespace MBath.Server.Services.CategoryServices
{
    public class CategorySrvc : ICategorySrvc
    {
        private readonly DataContext _context;

        public CategorySrvc(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<bool>> HasProductsAsync(int categoryId)
        {
            if (await _context.Products.AnyAsync(p => p.CategoryId == categoryId))
            {
                return new ServiceResponse<bool>
                {
                    Data = true
                };
            }
            return new ServiceResponse<bool>
            {
                Success = false
            };
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>> {
                Data = await _context.Categories.Where(c => c.Visible && !c.Deleted).ToListAsync()
             };

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetAdminCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>>
            {
                Data = await _context.Categories.Where(c=>!c.Deleted).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> AddCategoriesAsync(Category category)
        {
            

            category.Editing = category.IsNew = false;

            _context.Categories.Add(category);

            await _context.SaveChangesAsync();

            return await GetAdminCategoriesAsync();
        }

        public async Task<ServiceResponse<List<Category>>> UpdateCategoriesAsync(Category category)
        {
            var dbCategory = await GetCategory(category.Id);

            if(dbCategory== null)
            {
                return new ServiceResponse<List<Category>>
                {
                    Success = false,
                    Message = "Category not found."
                };
            }

            dbCategory.Name = category.Name;
            dbCategory.ImgURL = category.ImgURL;
            dbCategory.HasProducts= category.HasProducts;
            dbCategory.Visible= category.Visible;

            await _context.SaveChangesAsync();

            return await GetAdminCategoriesAsync();
        }

        public async Task<ServiceResponse<List<Category>>> DeleteCategoryAsync(int id)
        {
            var category = await GetCategory(id);
            if(category == null)
            {
                return new ServiceResponse<List<Category>>
                {
                    Success = false,
                    Message = "Category not found"
                };
            }

            category.Deleted= true;
            await _context.SaveChangesAsync();

            return await GetAdminCategoriesAsync();
        }


        private async Task<Category> GetCategory(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c=>c.Id==id);
        }
    }
}
