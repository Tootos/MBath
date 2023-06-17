using MBath.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSrvc _productService;
        public ProductController(IProductSrvc productService)
        {

            _productService = productService;

        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductAsync(int productId)
        {
            var result = await _productService.GetProductAsync(productId);

            return Ok(result);
        }


        [HttpGet("products/{categoryUrl}/{page}")]
        public async Task<ActionResult<ServiceResponse<ProductListResponse>>> GetProductsFromCategoryAsync(string categoryUrl,int page)
        {
            var result = await _productService.GetProductsfromCategoryAsync(categoryUrl,page);

            return Ok(result);
        }

        [HttpGet("search/{searchedText}/{page}")]
        public async Task<ActionResult<ServiceResponse<ProductListResponse>>> SearchProductsAsync(string searchedText,int page)
        {
            var result = await _productService.SearchProductsAsync(searchedText,page);

            return Ok(result);
        }

        [HttpGet("searchsuggestions/{searchedText}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetSuggestionProductsAsync(string searchedText)
        {
            var result = await _productService.GetProductSuggestionsAsync(searchedText);

            return Ok(result);
        }


    }
}
