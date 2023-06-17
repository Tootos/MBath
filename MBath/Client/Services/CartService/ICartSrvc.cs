using MBath.Shared.Models;

namespace MBath.Client.Services.CartServices
{
    public interface ICartSrvc
    {

        event Action OnChange;

        Task AddToCartAsync(CartItem item);

        Task<List<CartItem>> GetCartItemsAsync();

        Task<List<CartProductResponse>> GetCartProductsAsync();
        Task RemoveProductFromCartAsync(int productId, int productTypeId);

        Task UpdateQuantity(CartProductResponse product);

    }
}
