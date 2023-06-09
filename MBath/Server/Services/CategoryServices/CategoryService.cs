using Azure;
using MBath.Shared.Models;
using System.Reflection.Metadata.Ecma335;

namespace MBath.Server.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public Task<bool> DoesCategoryHaveProducts(int categoryID)//To be removed
        {
            return Task.FromResult(_context.Products
                .Any(p => p.CategoryId == categoryID));

        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetParentCategories()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.Where(p => p.ParentId == 0).ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories(string? categoryURL= null)
        {
            var response= new ServiceResponse<List<Category>>();            

                var parent = await _context.Categories.Where(p => p.URL == categoryURL).FirstOrDefaultAsync();
                if(parent!=null)
                {
                    response.Data = await _context.Categories.Where(p => p.ParentId == parent.Id).ToListAsync();
                }
                         
            return response;
        }

        public async Task<ServiceResponse<Category>> GetCategoryParent(int parentId)
        {
            var response = new ServiceResponse<Category>()
            {
                Data = await _context.Categories.Where(p => p.Id == parentId).FirstOrDefaultAsync()
            };

            return response;
        }

        
    }
}
