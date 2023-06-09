﻿

using MBath.Shared.Models;

namespace MBath.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<ProductListResponse>> GetProductsfromCategoryAsync(string categoryUrl, int page);
        
        Task<ServiceResponse<ProductListResponse>> SearchProductsAsync(string productName, int page);
        Task<ServiceResponse<List<string>>> GetProductSuggestionsAsync(string productName);

    }
}