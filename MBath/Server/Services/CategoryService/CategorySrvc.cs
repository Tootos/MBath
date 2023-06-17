using Azure;
using MBath.Shared.Models;
using System.Reflection.Metadata.Ecma335;

namespace MBath.Server.Services.CategoryServices
{
    public class CategorySrvc : ICategorySrvc
    {
        private readonly DataContext _context;

        public CategorySrvc(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<bool>> DoesCategoryHaveProductsAsync(int categoryId)
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
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetParentCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.Where(p => p.ParentId == 0).ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync(string? categoryURL= null)
        {
            var response= new ServiceResponse<List<Category>>();            
            if(categoryURL == null)
            {
                return response;
            }
                var parent = await _context.Categories.Where(p => p.URL == categoryURL).FirstOrDefaultAsync();
                if(parent!=null)
                {
                    response.Data = await _context.Categories.Where(p => p.ParentId == parent.Id).ToListAsync();
                }
                         
            return response;
        }

        public async Task<ServiceResponse<Category>> GetCategoryParentAsync(int parentId)
        {
            var response = new ServiceResponse<Category>()
            {
                Data = await _context.Categories.Where(p => p.Id == parentId).FirstOrDefaultAsync()
            };

            return response;
        }

        
    }
}
