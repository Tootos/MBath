
namespace MBath.Server.Services.ProductServices
{
    public class ProductSrvc : IProductSrvc
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _accessor;

        public ProductSrvc(DataContext context, IHttpContextAccessor accessor)
        {
            _context=context;
            _accessor = accessor;
        }

        
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            Product product = null;

            if (_accessor.HttpContext.User.IsInRole("Admin"))
            {
                
                product = await _context.Products
                    .Include(p => p.ProductVariants.Where(pv=> !pv.Deleted))
                    .ThenInclude(v => v.Variant)
                    .Include(p=>p.Images)
                    .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted);
            }
            else
            {
                product = await _context.Products
                    .Include(p => p.ProductVariants.Where(pv => pv.Visible && !pv.Deleted))
                    .ThenInclude(v => v.Variant)
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync(p => p.Id == productId && p.Visible && !p.Deleted);
            }
                 
                           
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
                .Where(p => p.Category.Url.ToLower().Contains(categoryUrl.ToLower()) && p.Visible &&!p.Deleted)
                .Include(p=>p.Images)
                .ToListAsync();
               

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
                                p.Description.ToLower().Contains(productName.ToLower())
                                && p.Visible && !p.Deleted)
                               .Include(p => p.Images)
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
                                p.Description.ToLower().Contains(searchedProduct.ToLower())
                                && p.Visible && !p.Deleted)
                                .ToListAsync();
        }

        public async Task<ServiceResponse<List<Product>>> GetAdminProductAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Where(p => !p.Deleted)
                .Include(p=>p.ProductVariants.Where(pv=>!pv.Deleted))
                .ThenInclude(v=>v.Variant)
                .Include(p => p.Images)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> AddProduct(Product product)
        {
            
            foreach(var variant in product.ProductVariants)
            {
                variant.Variant = null;
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return new ServiceResponse<Product>
            {
                Data = product
            };
        }

        public async Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            var dbProduct = await _context.Products
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p=>p.Id==product.Id);

            if(dbProduct == null)
            {
                return new ServiceResponse<Product> {
                    Message = "Product not found.",
                    Success = false
                };
            }

            dbProduct.Name = product.Name;
            dbProduct.Description= product.Description;
            dbProduct.CategoryId= product.CategoryId;
            dbProduct.ImgURL = product.ImgURL;
            dbProduct.Visible =product.Visible;

            var oldImages = dbProduct.Images;
            _context.Images.RemoveRange(oldImages);

            dbProduct.Images = product.Images;

            foreach(var variant in product.ProductVariants)
            {
                var dbVariant = await _context.ProductVariants
                    .SingleOrDefaultAsync(pv=> pv.ProductId == variant.ProductId &&
                    pv.VariantId == variant.VariantId);
                if (dbVariant == null)
                {
                    variant.Variant = null;
                    _context.ProductVariants.Add(variant);
                }
                else
                {
                    dbVariant.VariantId = variant.VariantId;
                    dbVariant.Price = variant.Price;
                    dbVariant.Visible = variant.Visible;
                    dbVariant.Deleted= variant.Deleted;
                }
            }
            
            await _context.SaveChangesAsync();

            return new ServiceResponse<Product> { Data= product };
        }

        public async Task<ServiceResponse<bool>> DeleteProduct(int productId)
        {
            var dbProduct= await _context.Products.FindAsync(productId);
            if(dbProduct == null)
            {
                return new ServiceResponse<bool>
                {
                    Message="Product not found",
                    Success = false

                };
            }
            dbProduct.Deleted = true;
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Message="Product Deleted.", Success = true };
        }
    }
}
