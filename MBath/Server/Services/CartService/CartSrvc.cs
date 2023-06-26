
namespace MBath.Server.Services.CartServices
{
    public class CartSrvc : ICartSrvc
    {
        private readonly  DataContext _context;
        private readonly IAuthenticationSrvc _authentication;
       

        public CartSrvc(DataContext context, 
            IAuthenticationSrvc authentication)
        {
            _context = context;
            _authentication = authentication;           
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
                            VariantId= variant.Id,
                            VariantName = variant.Name,
                            Price = variant.Price,
                            Quantity= item.Quantity
                        };

                        response.Data.Add(cartProduct);
                       
                    }
                }               
            }
            return response;
        }

        public async Task<ServiceResponse<List<CartProductResponse>>> StoreCartItems(List<CartItem> cartItems)
        {
            cartItems.ForEach(ci => ci.UserId = _authentication.GetUserId());
            _context.CartItems.AddRange(cartItems);
            await _context.SaveChangesAsync();

            return await GetDbCartProducts();
        }
        public async Task<ServiceResponse<int>> GetCartItemsCount()
        {
            var count = (await _context.CartItems.Where(ci => ci.UserId == _authentication.GetUserId()).ToListAsync()).Count;

            return new ServiceResponse<int> { Data = count };
        }

        public async Task<ServiceResponse<List<CartProductResponse>>> GetDbCartProducts(int? userId = null)
        {
            if(userId==null)
                userId = _authentication.GetUserId();

            return await GetCartProductsAsync(await _context.CartItems
                .Where(ci => ci.UserId == userId)
                .ToListAsync());
        }

        public async Task<ServiceResponse<bool>> AddToCart(CartItem cartItem)
        {
            cartItem.UserId =_authentication.GetUserId();

            var sameItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId && 
                ci.VariantId== cartItem.VariantId && ci.UserId==cartItem.UserId);

            if (sameItem == null)
            {
                _context.CartItems.Add(cartItem);
            }
            else
            {
                sameItem.Quantity += cartItem.Quantity;
            }

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }

        public async Task<ServiceResponse<bool>> UpdateCartQuantity(CartItem cartItem)
        {
            var dbCartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci=>ci.UserId==_authentication.GetUserId() && 
                ci.ProductId==cartItem.ProductId && ci.VariantId==cartItem.VariantId);

            if(dbCartItem == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Message = "Cart item does not exist."
                };
            }

            dbCartItem.Quantity = cartItem.Quantity;
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Success=true, Message="Quantity Updated" };
        }

        public async Task<ServiceResponse<bool>> RemoveFromCart(int productId, int variantId)
        {
            var dbCartItem = await _context.CartItems
               .FirstOrDefaultAsync(ci => ci.UserId == _authentication.GetUserId() &&
               ci.ProductId == productId && ci.VariantId == variantId);

            if (dbCartItem == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Message = "Cart item does not exist."
                };
            }

            _context.CartItems.Remove(dbCartItem);
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }
    }
}
