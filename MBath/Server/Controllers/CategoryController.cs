
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategorySrvc _categoryService;

        public CategoryController(ICategorySrvc categoryService)
        {
            _categoryService = categoryService;               
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoriesAsync()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }

        [HttpGet("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetAdminCategoriesAsync()
        {
            var result = await _categoryService.GetAdminCategoriesAsync();
            return Ok(result);
        }

        [HttpPost("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> AddCategoriesAsync(Category category)
        {
            var result = await _categoryService.AddCategoriesAsync(category);
            return Ok(result);
        }

        [HttpDelete("admin/{categoryId}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> DeleteCategory(int categoryId)
        {
            var result = await _categoryService.DeleteCategoryAsync(categoryId);
            return Ok(result);
        }

        [HttpPut("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Category>>> UpdateCategoriesAsync(Category category)
        {
            var result = await _categoryService.UpdateCategoriesAsync(category);
            return Ok(result);
        }


        [HttpGet("hasproducts/{categoryId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> HasProductsAsync(int categoryId)
        {
            var result = await _categoryService.HasProductsAsync(categoryId);
            return Ok(result);
        }
      

    }
}
