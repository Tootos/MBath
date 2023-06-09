using MBath.Shared.DataTransferObjects;
using MBath.Shared.Models;

namespace MBath.Server.Services.CartServices
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProductsAsync(List<CartItem> cartItems);


    }
}
