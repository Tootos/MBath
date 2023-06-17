using System.Net.Http.Json;

namespace MBath.Client.Services.CartServices
{
    public class CartSrvc :ICartSrvc
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;
       
  
        public event Action OnChange;

        public CartSrvc(ILocalStorageService localStorage, HttpClient http)
        {
            _localStorage = localStorage;
            _http = http;
        }

        

        public async Task AddToCartAsync(CartItem item)
        {
            var cart = await  _localStorage.GetItemAsync<List<CartItem>>("cart");

            if(cart==null)
            {
                cart= new List<CartItem>();
            }

            var sameItem= cart
                .Find(c=>c.ProductId==item.ProductId && c.VariantId==item.VariantId);
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }

            await _localStorage.SetItemAsync("cart",cart);
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            if(cart== null)
            {
                cart= new List<CartItem>();
            }

            return cart;
        }

        public async Task<List<CartProductResponse>> GetCartProductsAsync()
        {
            var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            var products = await _http.PostAsJsonAsync("api/cart/products", cartItems);

            var result = await products.
                Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
            
             return result.Data;
            
            
        }

        public async Task RemoveProductFromCartAsync(int productId, int variantId)
        {
            var cart= await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart== null)
            {
                return;
            }

            var cartItem= cart
                .Find(c=>c.ProductId==productId && c.VariantId==variantId);
            if(cartItem!=null)
            {
                cart.Remove(cartItem);
                await _localStorage.SetItemAsync("cart", cart);
                OnChange.Invoke();
            }

        }

        public async Task UpdateQuantity(CartProductResponse product)
        {
            var cart= await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem= cart
                .Find(c=>c.ProductId == product.ProductId && c.VariantId== product.VariantId);
            if (cartItem!=null)
            {
                cartItem.Quantity += product.Quantity;
                await _localStorage.SetItemAsync("cart", cart);
            }
        }
    }
}
