
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartSrvc _cartService;

        public CartController(ICartSrvc cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetCartProductsAsync(List<CartItem> cartItems)
        {
            var result = await _cartService.GetCartProductsAsync(cartItems);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> StoreCartItemsAsync(List<CartItem> cartItems)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = await _cartService.StoreCartItems(cartItems);

            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddCartItemAsync(CartItem cartItem)
        {
            var result = await _cartService.AddToCart(cartItem);

            return Ok(result);
        }

        [HttpPut("update-quantity")]
        public async Task<ActionResult<ServiceResponse<bool>>> UpdateCartQuantityAsync(CartItem cartItem)
        {
            var result = await _cartService.UpdateCartQuantity(cartItem);

            return Ok(result);
        }

        [HttpGet("count")]
        public async Task<ActionResult<ServiceResponse<int>>> GetCartItemsCount()
        {
            var result = await _cartService.GetCartItemsCount();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetStoredProducts()
        {
            var result = await _cartService.GetDbCartProducts();
            return Ok(result);
        }

        [HttpDelete("{productId}/{variantId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> RemoveFromCart(int productId, int variantId)
        {
            var result= await _cartService.RemoveFromCart(productId, variantId);
            return Ok(result);
        }


    }
}
