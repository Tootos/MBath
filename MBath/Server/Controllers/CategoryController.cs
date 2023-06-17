using MBath.Shared.Models;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("parent/{parentId}")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoryParentAsync(int parentId)
        {
            var result = await _categoryService.GetCategoryParentAsync(parentId);
            return Ok(result);
        }

        [HttpGet("{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoriesAsync(string categoryUrl)
        {
            var result= await _categoryService.GetCategoriesAsync(categoryUrl);
            return Ok(result);
        }
       

        [HttpGet("hasproducts/{categoryId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DoesCategoryHaveProductsAsync(int categoryId)
        {
            var result = await _categoryService.DoesCategoryHaveProductsAsync(categoryId);
            return Ok(result);
        }

        [HttpGet("parents")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetParentCategoriesAsync()
        {
            var result = await _categoryService.GetParentCategoriesAsync();
            return Ok(result);
        }

    }
}
