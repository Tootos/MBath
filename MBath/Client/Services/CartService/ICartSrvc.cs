using MBath.Shared.Models;

namespace MBath.Client.Services.CartService
{
    public interface ICartSrvc
    {

        event Action OnChange;

        Task AddToCartAsync(CartItem item);
        Task<List<CartProductResponse>> GetCartProductsAsync();
        Task RemoveProductFromCartAsync(int productId, int productTypeId);

        Task UpdateQuantity(CartProductResponse product);
        Task StoreCartItems(bool emptyLocalCart);

        Task GetCartItemsCount();
    }
}
