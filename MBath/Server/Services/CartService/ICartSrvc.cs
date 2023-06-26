

namespace MBath.Server.Services.CartServices
{
    public interface ICartSrvc
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProductsAsync(List<CartItem> cartItems);

        Task<ServiceResponse<List<CartProductResponse>>> StoreCartItems(List<CartItem> cartItems);

        Task<ServiceResponse<bool>> AddToCart(CartItem cartItem);

        Task<ServiceResponse<bool>> RemoveFromCart(int productId, int variantId);

        Task<ServiceResponse<bool>> UpdateCartQuantity(CartItem cartItem);

        Task<ServiceResponse<int>> GetCartItemsCount();

        Task<ServiceResponse<List<CartProductResponse>>> GetDbCartProducts(int? userId=null);
    }
}
