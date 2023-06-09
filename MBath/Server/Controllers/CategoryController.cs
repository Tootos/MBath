using MBath.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;               
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoriesAsync()
        {
            var result = await _categoryService.GetCategories();
            return Ok(result);
        }

        [HttpGet("parent/{parentId}")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoryParentAsync(int parentId)
        {
            var result = await _categoryService.GetCategoryParent(parentId);
            return Ok(result);
        }

        [HttpGet("{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoriesAsync(string categoryUrl)
        {
            var result= await _categoryService.GetCategories(categoryUrl);
            return Ok(result);
        }
       

        [HttpGet("hasproducts/{categoryId}")]
        public async Task<ActionResult<bool>> DoesCategoryHaveProducts(int categoryId)//To be removed
        {
            var result = await _categoryService.DoesCategoryHaveProducts(categoryId);
            return Ok(result);
        }

        [HttpGet("parents")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetParentCategoriesAsync()
        {
            var result = await _categoryService.GetParentCategories();
            return Ok(result);
        }

    }
}
