using MBath.Shared.Models;

namespace MBath.Server.Services.CartServices
{
    public class CartSrvc : ICartSrvc
    {
        private readonly  DataContext _context;

        public CartSrvc(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<CartProductResponse>>> GetCartProductsAsync(List<CartItem> cartItems)
        {
            var response = new ServiceResponse<List<CartProductResponse>>()
            {
                Data = new List<CartProductResponse>()
            };

            foreach(var item in cartItems)
            {
                var product= await _context.Products
                    .Where(p=>p.Id==item.ProductId).FirstOrDefaultAsync();

                if (product != null)
                {
                    var variant= await _context.Variants
                        .Where(v=>v.Id==item.VariantId).FirstOrDefaultAsync();
                    if(variant != null)
                    {
                        var cartProduct = new CartProductResponse()
                        {
                            ProductId = product.Id,
                            ProductName = product.Name,
                            ImgUrl = product.ImgURL,
                            VariantId = variant.Id,
                            Price = variant.Price,
                            Quantity= item.Quantity
                        };

                        response.Data.Add(cartProduct);
                       
                    }
                }               
            }
            return response;
        }

     
    }
}
