using MBath.Shared.Models;

namespace MBath.Server.Services.ProductServices
{
    public class ProductSrvc : IProductSrvc
    {
        private readonly DataContext _context;

        public ProductSrvc(DataContext context)
        {
            _context=context;
        }

        
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products                
                .Include(p=>p.Variants)
                .FirstOrDefaultAsync(p=>p.Id==productId);
                
                           
            if (product == null)
            {
                response.Success = false;
                response.Message = "The product was not found";
            }
            else
            {
                response.Data= product;
            }
            return response;
        }

        public async Task<ServiceResponse<ProductListResponse>> GetProductsfromCategoryAsync(string categoryUrl,int page)
        {
            float pageResults = 12f;

            var products = await _context.Products
                .Where(p => p.Category.URL.ToLower().Contains(categoryUrl.ToLower())).ToListAsync();
               

            var pageCount = Math.Ceiling(products.Count/pageResults);

            
            var response =  new ServiceResponse<ProductListResponse>()
            {
                Data = new ProductListResponse()
                {               
                     Products = products.Skip((page-1)*(int)pageResults).Take((int)pageResults).ToList(),
                     Pages=(int)pageCount,
                     CurrentPage=page
                }
            };
            return response;
        }

        

        public async Task<ServiceResponse<ProductListResponse>> SearchProductsAsync(string productName, int page)
        {
            float pageResults = 6f;

            var pageCount = Math.Ceiling((await FindProductString(productName)).Count / pageResults);

            var products= await _context.Products.Where(p => p.Name.ToLower().Contains(productName.ToLower())
                                ||
                                p.Description.ToLower().Contains(productName.ToLower()))
                               .Skip((page-1)*(int)pageResults)
                               .Take((int)pageResults).ToListAsync();

            var response = new ServiceResponse<ProductListResponse>()
            {
                Data= new ProductListResponse()
                {
                    Products= products,
                    Pages=(int)pageCount,
                    CurrentPage=page
                }

            };

            return response;
        }
        public async Task<ServiceResponse<List<string>>> GetProductSuggestionsAsync(string searchedText)
        {
            var products = await FindProductString(searchedText);

            List<string> results = new List<string>();

            foreach (var product in products)
            {
                if (product.Name.Contains(searchedText, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(product.Name);
                }
            }

            return new ServiceResponse<List<string>> { Data = results };
        }

        private Task<List<Product>> FindProductString(string searchedProduct)
        {
            return _context.Products.
                                Where(p => p.Name.ToLower().Contains(searchedProduct.ToLower())
                                ||
                                p.Description.ToLower().Contains(searchedProduct.ToLower())).ToListAsync();
        }
    }
}
